using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem._Models
{
    internal class Client 
    {
        public Client() 
        {
        }

        public void DeleteClient(string name, int clientId)
        {
            using (var db = new Database())
            {
                // Check if the client currently has vehicles in possession
                string checkQuery = "SELECT In_Possession FROM clientProfiles WHERE ClientID = @ClientID";
                string inPossessionStr = db.Scalar(checkQuery, new Dictionary<string, object> { { "@ClientID", clientId } });
                if (int.TryParse(inPossessionStr, out int inPossession) && inPossession > 0)
                {
                    MessageBox.Show($"Cannot delete client '{name}' because they currently have {inPossession} vehicle(s) in possession. Please return all vehicles first.", "Action Prohibited", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {name}'s data?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM clientProfiles WHERE ClientID = @ClientID";
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

                using (var db = new Database())
                {
                    return db.Select(sql, parameters);
                }
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
