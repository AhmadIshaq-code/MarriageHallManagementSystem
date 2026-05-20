using MY_Class_Project.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_Class_Project.Database
{
    public class CustomerDB
    {
        DBConnection db = new DBConnection();

        public void AddCustomer(Customer c)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string q = "INSERT INTO customers(CustName, CustAdd, CustPhone) VALUES(@n,@a,@p)";
                MySqlCommand cmd = new MySqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@n", c.CustName);
                cmd.Parameters.AddWithValue("@a", c.CustAdd);
                cmd.Parameters.AddWithValue("@p", c.CustPhone);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetCustomers()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM customers", conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public void DeleteCustomer(int id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string q = "DELETE FROM customers WHERE CustId=@id";
                MySqlCommand cmd = new MySqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCustomer(Customer c)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string q = "UPDATE customers SET CustName=@n, CustAdd=@a, CustPhone=@p WHERE CustId=@id";

                MySqlCommand cmd = new MySqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@n", c.CustName);
                cmd.Parameters.AddWithValue("@a", c.CustAdd);
                cmd.Parameters.AddWithValue("@p", c.CustPhone);
                cmd.Parameters.AddWithValue("@id", c.CustId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
