using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_Class_Project.Database
{

    public class LoginDB
    {
        DBConnection db = new DBConnection();

        public DataTable LoginStaff(string name)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string q =
                "SELECT * FROM staff WHERE StaffName=@n";

                MySqlCommand cmd =
                    new MySqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@n", name);

                MySqlDataAdapter da =
                    new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}
