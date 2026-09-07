using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem._Models
{
    internal class Users
    {
        Database _db;
        public Users(Database db)
        {
            _db = db;
        }
        public bool AddUser(User user)
        {
            string checkQuery = "SELECT COUNT(*) FROM CarRentalUsers WHERE Username = @username";
            var parameters = new Dictionary<string, object>
        {
            { "@username", user.Username }
        };

            string countResult = _db.Scalar(checkQuery, parameters);
            if (int.Parse(countResult) > 0)
            {
                return false; // Username already exists
            }

            string insertQuery = "INSERT INTO CarRentalUsers (Username, Password, Status) VALUES (@username, @password, @status)";
            parameters.Add("@password", user.Password);
            parameters.Add("@status", user.Status);

            _db.Execute(insertQuery, parameters);
            return true;
        }

        public void UpdateUser(User user)
        {
            string updateQuery = "UPDATE CarRentalUsers SET Username = @username, Password = @password, Status = @status WHERE UserID = @id";
            var parameters = new Dictionary<string, object>
        {
            { "@username", user.Username },
            { "@password", user.Password },
            { "@status", user.Status },
            { "@id", user.Id }
        };

            _db.Execute(updateQuery, parameters);
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
    }

}

