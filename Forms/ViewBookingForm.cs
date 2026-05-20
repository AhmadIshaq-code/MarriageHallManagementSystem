using MY_Class_Project.Database;
using MY_Class_Project.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace MY_Class_Project.Forms
{
    public partial class ViewBooking : Form
    {
        public ViewBooking()
        {
            InitializeComponent();
            
        }

        private void ViewBooking_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            BookingDB db = new BookingDB();

            DataTable dt = db.GetBookings();

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = dt;

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Booking b = new Booking();

                b.BId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["BId"].Value);

                b.BDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["BDate"].Value);

                b.BTime = dataGridView1.Rows[e.RowIndex].Cells["BTime"].Value.ToString();

                b.CustName = dataGridView1.Rows[e.RowIndex].Cells["CustName"].Value.ToString();

                b.Persons = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Persons"].Value);

                b.Dishes = dataGridView1.Rows[e.RowIndex].Cells["Dishes"].Value.ToString();

                b.Drinks = dataGridView1.Rows[e.RowIndex].Cells["Drinks"].Value.ToString();

                b.CostDrink = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CostDrink"].Value);

                b.CostFood = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CostFood"].Value);

                b.OtherCharges = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OtherCharges"].Value);

                b.GrdTotal = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["GrdTotal"].Value);

                b.Advance = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Advance"].Value);

                b.Balance = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Balance"].Value);

                InvoiceForm invoice = new InvoiceForm(b);

                invoice.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}