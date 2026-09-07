using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CarRentalManagementSystem._Models
{
    internal class Database : IDisposable
    {
        DataTable dtable;
        SqlConnection sqlcon;
        SqlDataAdapter sqlda;
        SqlCommand sqlcom;
        private readonly string constring;

        private static string GetConnectionString()
        {
            string[] searchRoots = new string[]
            {
                AppDomain.CurrentDomain.BaseDirectory,
                System.IO.Path.GetDirectoryName(typeof(Database).Assembly.Location)
            };

            string mdfPath = null;

            foreach (var root in searchRoots)
            {
                if (string.IsNullOrEmpty(root)) continue;

                string current = root;
                for (int i = 0; i < 5; i++)
                {
                    string candidate = System.IO.Path.Combine(current, "car_rental.mdf");
                    if (System.IO.File.Exists(candidate))
                    {
                        mdfPath = System.IO.Path.GetFullPath(candidate);
                        break;
                    }
                    var parent = System.IO.Directory.GetParent(current);
                    if (parent == null) break;
                    current = parent.FullName;
                }

                if (mdfPath != null) break;
            }

            if (mdfPath != null && System.IO.File.Exists(mdfPath))
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.GetDirectoryName(mdfPath));
                return $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={mdfPath};Integrated Security=True;Connect Timeout=30;";
            }

            try
            {
                var setting = System.Configuration.ConfigurationManager.ConnectionStrings["CarRentalManagementSystem.Properties.Settings.car_rentalConnectionString"];
                if (setting != null && !string.IsNullOrWhiteSpace(setting.ConnectionString))
                {
                    return setting.ConnectionString;
                }
            }
            catch { }

            return $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\car_rental.mdf;Integrated Security=True;Connect Timeout=30;";
        }

        public Database()
        {
            constring = GetConnectionString();
            sqlcon = new SqlConnection(constring);
            sqlcon.Open();
        }
        public DataTable Select(string sql, Dictionary<string, object> parameters = null)
        {
            dtable = new DataTable();
            using (sqlcom = new SqlCommand(sql, sqlcon))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        sqlcom.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                sqlda = new SqlDataAdapter(sqlcom);
              sqlda.Fill(dtable);
            }
            return dtable;
        }

        // Method for executing insert, update, and delete queries with parameters
        public int Execute(string sql, Dictionary<string, object> parameters = null)
        {
            using (sqlcom = new SqlCommand(sql, sqlcon))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        sqlcom.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                return sqlcom.ExecuteNonQuery();
            }
        }

        // Method for getting a single scalar value with parameters
        public string Scalar(string sql, Dictionary<string, object> parameters = null)
        {
            using (sqlcom = new SqlCommand(sql, sqlcon))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        sqlcom.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                object result = sqlcom.ExecuteScalar();
                return result?.ToString() ?? string.Empty;
            }
        }

        public void Dispose()
        {
            sqlcon?.Close();
            sqlcon?.Dispose();
            sqlda?.Dispose();
            sqlcom?.Dispose();
            dtable?.Dispose();
        }
    }
}
