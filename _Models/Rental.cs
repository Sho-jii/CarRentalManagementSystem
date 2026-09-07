using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem._Models
{
    public class Rental
    {
        public Rental()
        {

        }
        string sql;
        public DataTable LoadRentData()
        {
            sql = @"                      
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
                            WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 
                                (DATEDIFF(DAY, GETDATE(), vr.RentDate) * 200) 
                            ELSE 
                                ((DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice)
                                + 
                                CASE 
                                    WHEN CAST(vr.RentDate AS DATE) > CAST(vr.DateAdded AS DATE) THEN 
                                        DATEDIFF(DAY, vr.DateAdded, vr.RentDate) * 200
                                    ELSE 0
                                END
                        END AS Total,
                        vr.DamageFee,
                        vr.DateAdded
                    FROM 
                        vehicleRentals AS vr
                    LEFT JOIN 
                        vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
                    LEFT JOIN 
                        clientProfiles AS cp ON vr.ClientID = cp.ClientID";

            using (Database db = new Database())
            {
                return db.Select(sql);
            }
        }

        public DataTable LoadRentDataToday(string searchTerm = "", string status = "Status (All)")
        {
            sql = @"
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
                            WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 
                                (DATEDIFF(DAY, GETDATE(), vr.RentDate) * 200) 
                            ELSE 
                                ((DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice)
                                + 
                                CASE 
                                    WHEN CAST(vr.RentDate AS DATE) > CAST(vr.DateAdded AS DATE) THEN 
                                        DATEDIFF(DAY, vr.DateAdded, vr.RentDate) * 200
                                    ELSE 0
                                END
                        END AS Total,
                        vr.DamageFee,
                        vr.DateAdded
                    FROM 
                        vehicleRentals AS vr
                    LEFT JOIN 
                        vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
                    LEFT JOIN 
                        clientProfiles AS cp ON vr.ClientID = cp.ClientID
                    WHERE (CAST(vr.DateAdded AS DATE) = CAST(GETDATE() AS DATE)
                        OR CAST(vr.ReturnDate AS DATE) = CAST(GETDATE() AS DATE))
                      AND cp.Name LIKE @searchTerm";

            // Add status filter
            if (status != "Status (All)")
            {
                sql += " AND vr.Status = @status";
            }

            using (Database db = new Database())
            {
                var parameters = new Dictionary<string, object>
                {
                    { "@searchTerm", searchTerm + "%" },
                    { "@status", status }
                };

                return db.Select(sql, parameters);
            }
        }
        public DataTable allStatus(string statusTXT)
        {
            sql = $@"                      
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
                            WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 
                                (DATEDIFF(DAY, GETDATE(), vr.RentDate) * 200) 
                            ELSE 
                                ((DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice)
                                + 
                                CASE 
                                    WHEN CAST(vr.RentDate AS DATE) > CAST(vr.DateAdded AS DATE) THEN 
                                        DATEDIFF(DAY, vr.DateAdded, vr.RentDate) * 200
                                    ELSE 0
                                END
                        END AS Total,
                        vr.DamageFee,
                        vr.DateAdded
                    FROM 
                        vehicleRentals AS vr
                    LEFT JOIN 
                        vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
                    LEFT JOIN 
                        clientProfiles AS cp ON vr.ClientID = cp.ClientID
                        WHERE vr.Status = @Status";
            using (Database db = new Database())
            {
                var parameters = new Dictionary<string, object>
                {
                    { "@Status", statusTXT }
                };
                return db.Select(sql, parameters);
            }
        }
        public DataTable GetRentalDataBySearch(string searchText, string status)
        {
            string sql = $@"
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
                            WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 
                                (DATEDIFF(DAY, GETDATE(), vr.RentDate) * 200) 
                            ELSE 
                                ((DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice)
                                + 
                                CASE 
                                    WHEN CAST(vr.RentDate AS DATE) > CAST(vr.DateAdded AS DATE) THEN 
                                        DATEDIFF(DAY, vr.DateAdded, vr.RentDate) * 200
                                    ELSE 0
                                END
                        END AS Total,
                        vr.DamageFee,
                        vr.DateAdded
                        FROM 
                            vehicleRentals AS vr
                        LEFT JOIN 
                            vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
                        LEFT JOIN 
                            clientProfiles AS cp ON vr.ClientID = cp.ClientID
                            WHERE cp.Name LIKE @SearchText AND vr.Status = @Status";

            using (var db = new Database())
            {
                var parameters = new Dictionary<string, object>
            {
                 { "@SearchText", searchText + "%" },
                 { "@Status", status }
            };
                return db.Select(sql, parameters);
            }
        }
        public DataTable GetRentalDataBySearchAS(string searchTexts)
        {
            string sql = $@"
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
                            WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 
                                (DATEDIFF(DAY, GETDATE(), vr.RentDate) * 200) 
                            ELSE 
                                ((DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice)
                                + 
                                CASE 
                                    WHEN CAST(vr.RentDate AS DATE) > CAST(vr.DateAdded AS DATE) THEN 
                                        DATEDIFF(DAY, vr.DateAdded, vr.RentDate) * 200
                                    ELSE 0
                                END
                        END AS Total,
                        vr.DamageFee,
                        vr.DateAdded
                        FROM 
                            vehicleRentals AS vr
                        LEFT JOIN 
                            vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
                        LEFT JOIN 
                            clientProfiles AS cp ON vr.ClientID = cp.ClientID
                            WHERE cp.Name LIKE @SearchText";

            using (var db = new Database())
            {
                var parameters = new Dictionary<string, object>
            {
                 { "@SearchText", searchTexts + "%" }
            };
                return db.Select(sql, parameters);
            }
        }
    }
}
