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

        private readonly string localDBFilePath = @"C:\Users\Jarib\source\repos\CarRentalManagementSystem\car_rental.mdf";

        public Database()
        {
            // for opening a connection to the sql server
            constring = String.Format("data source=(LocalDB)\\MSSQLLocalDB;attachdbfilename={0};integrated security=true;", localDBFilePath);
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
