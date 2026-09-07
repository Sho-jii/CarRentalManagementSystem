using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CarRentalManagementSystem._Forms;
using CarRentalManagementSystem._Pages;
using System.Web.UI;
using System.Windows.Forms;

namespace CarRentalManagementSystem._Models
{
    internal class Client 
    {
        private Database db;
        public Client() 
        {
            db = new Database();
        }
        public void DeleteClient(string name, int clientId)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {name}'s data?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM clientProfiles WHERE ClientID = @ClientID";

                using (var db = new Database())
                {
                    db.Execute(sql, new Dictionary<string, object> { { "@ClientID", clientId } });
                    MessageBox.Show("Client deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public DataTable LoadClientsByNameAndGender(string name, string gender)
        {
            try
            {
                string sql = "SELECT * FROM clientProfiles WHERE Name LIKE @Name";
                var parameters = new Dictionary<string, object>
                {
                    { "@Name", name + "%" }
                };

                if (!string.IsNullOrEmpty(gender) && gender != "Gender (All)")
                {
                    sql += " AND Gender = @Gender";
                    parameters.Add("@Gender", gender);
                }

                return db.Select(sql, parameters); // Assuming `db.Select` executes the query and returns a DataTable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public DataTable GetClients(string searchQuery = "", string genderFilter = "")
        {
            string sql = @"
                        SELECT *
                        FROM clientProfiles
                        WHERE 
                        (Name LIKE @searchQuery OR @searchQuery = '')
                        AND (Gender = @genderFilter OR @genderFilter = '')";

            using (Database db = new Database())
            {
                return db.Select(sql, new Dictionary<string, object>
        {
            { "@searchQuery", searchQuery + "%" },
            { "@genderFilter", genderFilter }
        });
            }
        }

    }
}
