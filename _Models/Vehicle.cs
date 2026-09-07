using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem._Models
{
    internal class Vehicle 
    {
        public Vehicle() 
        {
        }

        public void DeleteVehicle(string model, int vehicleId)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to remove {model}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM vehicleInventory WHERE VehicleID = @VehicleID";

                using (var db = new Database())
                {
                    db.Execute(sql, new Dictionary<string, object> { { "@VehicleID", vehicleId } });
                    MessageBox.Show("Vehicle deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public DataTable LoadVehiclesByTransmission(string transmission, string searchText)
        {
            try
            {
                string sql = "SELECT * FROM vehicleInventory WHERE Transmission = @Transmission AND Model LIKE @SearchText";

                var parameters = new Dictionary<string, object>
                {
                    { "@Transmission", transmission },
                    { "@SearchText", "%" + searchText + "%" }
                };

                using (var db = new Database())
                {
                    return db.Select(sql, parameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public DataTable LoadVehiclesBySearch(string searchText)
        {
            try
            {
                string sql = "SELECT * FROM vehicleInventory WHERE Model LIKE @SearchText";

                var parameters = new Dictionary<string, object>
                {
                    { "@SearchText", "%" + searchText + "%" }
                };

                using (var db = new Database())
                {
                    return db.Select(sql, parameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles by search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public DataTable LoadVehiclesByTransmissionAvail(string transmission, string searchText)
        {
            try
            {
                // Only return vehicles that are Available and NOT in damaged/bad condition
                string sql = @"SELECT * FROM vehicleInventory 
                               WHERE Status = 'Available' 
                                 AND Condition NOT IN ('Damaged', 'VeryBad', 'Very Bad', 'Bad', 'Needs Repair') 
                                 AND Transmission = @Transmission 
                                 AND Model LIKE @SearchText";

                var parameters = new Dictionary<string, object>
                {
                    { "@Transmission", transmission },
                    { "@SearchText", "%" + searchText + "%" }
                };

                using (var db = new Database())
                {
                    return db.Select(sql, parameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available vehicles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public DataTable LoadVehiclesBySearchAvail(string searchText)
        {
            try
            {
                // Only return vehicles that are Available and NOT in damaged/bad condition
                string sql = @"SELECT * FROM vehicleInventory 
                               WHERE Status = 'Available' 
                                 AND Condition NOT IN ('Damaged', 'VeryBad', 'Very Bad', 'Bad', 'Needs Repair') 
                                 AND Model LIKE @SearchText";

                var parameters = new Dictionary<string, object>
                {
                    { "@SearchText", "%" + searchText + "%" }
                };

                using (var db = new Database())
                {
                    return db.Select(sql, parameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available vehicles by search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public DataTable GetReturnableVehicles(string searchQuery = "")
        {
            string sql = @"
                SELECT 
                vr.Id,
                vr.RentDate,
                vr.VehicleID, 
                vr.ClientID, 
                vi.Model AS VehicleModel, 
                cp.Name AS ClientName, 
                vr.ConditionBefore,
                vr.ConditionAfter,
                vr.Status,
                vr.ReturnDate,
                vr.DailyHirePrice,
                CASE 
                    WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 0
                    ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1
                END AS Days,
                CASE 
                    WHEN CAST(vr.RentDate AS DATE) > CAST(vr.DateAdded AS DATE) 
                         THEN (DATEDIFF(DAY, vr.DateAdded, vr.RentDate) * 200) 
                              + ((DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice)
                    WHEN CAST(vr.RentDate AS DATE) <= CAST(vr.DateAdded AS DATE) 
                         THEN (DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice
                    ELSE 0
                END AS Total,
                vr.DateAdded
                FROM 
                    vehicleRentals AS vr
                LEFT JOIN 
                    vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
                LEFT JOIN 
                    clientProfiles AS cp ON vr.ClientID = cp.ClientID
                WHERE 
                    vr.Status = 'In-Possession'
                    AND CAST(vr.RentDate AS DATE) <= CAST(GETDATE() AS DATE)
                    AND vi.Model LIKE @searchQuery
                ORDER BY 
                    vr.RentDate DESC";

            using (Database db = new Database())
            {
                return db.Select(sql, new Dictionary<string, object>
            {
                { "@searchQuery", "%" + searchQuery + "%" }
            });
            }
        }
    }
}
