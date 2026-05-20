using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using MY_Class_Project.Models;
using BCrypt.Net;


namespace MY_Class_Project.Database
{

    public class StaffDB
    {
        DBConnection db = new DBConnection();

        public void AddStaff(Staff s)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string q = "INSERT INTO staff(StaffName, StaffPhone, StaffGender, StaffPassword) VALUES(@n,@p,@g,@pass)";
                MySqlCommand cmd = new MySqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@n", s.StaffName);
                cmd.Parameters.AddWithValue("@p", s.StaffPhone);
                cmd.Parameters.AddWithValue("@g", s.StaffGender);

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(s.StaffPassword);

                cmd.Parameters.AddWithValue("@pass", hashedPassword);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetStaff()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM staff", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void DeleteStaff(int id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string q = "DELETE FROM staff WHERE StaffId=@id";
                MySqlCommand cmd = new MySqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStaff(Staff s)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string q = "UPDATE staff SET StaffName=@n, StaffPhone=@p, StaffGender=@g, StaffPassword=@pass WHERE StaffId=@id";

                MySqlCommand cmd = new MySqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@n", s.StaffName);
                cmd.Parameters.AddWithValue("@p", s.StaffPhone);
                cmd.Parameters.AddWithValue("@g", s.StaffGender);
                cmd.Parameters.AddWithValue("@pass", s.StaffPassword);
                cmd.Parameters.AddWithValue("@id", s.StaffId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}