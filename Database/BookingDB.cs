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
    public class BookingDB
    {
        DBConnection db = new DBConnection();

        public void AddBooking(Booking b)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string q = @"INSERT INTO bookingtable
(BDate,BTime,CustId,CustName,Persons,Dishes,Drinks,
CostDrink,CostFood,OtherCharges,GrdTotal,
Advance,Balance)

VALUES
(@d,@t,@cid,@cn,@p,@dish,@drink,
@cd,@cf,@oc,@gt,@a,@b)";

                MySqlCommand cmd = new MySqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@d", b.BDate);
                cmd.Parameters.AddWithValue("@t", b.BTime);
                cmd.Parameters.AddWithValue("@cid", b.CustId);
                cmd.Parameters.AddWithValue("@cn", b.CustName);
                cmd.Parameters.AddWithValue("@p", b.Persons);
                cmd.Parameters.AddWithValue("@dish", b.Dishes);
                cmd.Parameters.AddWithValue("@drink", b.Drinks);
                cmd.Parameters.AddWithValue("@cd", b.CostDrink);
                cmd.Parameters.AddWithValue("@cf", b.CostFood);
                cmd.Parameters.AddWithValue("@oc", b.OtherCharges);
                cmd.Parameters.AddWithValue("@gt", b.GrdTotal);
                cmd.Parameters.AddWithValue("@a", b.Advance);
                cmd.Parameters.AddWithValue("@b", b.Balance);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetBookings()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string q = "SELECT * FROM bookingtable";

                MySqlDataAdapter da = new MySqlDataAdapter(q, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}