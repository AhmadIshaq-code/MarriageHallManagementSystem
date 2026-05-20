using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_Class_Project.Forms
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            
            InitializeComponent();
            
        }


        private void btnBooking_Click_1(object sender, EventArgs e)
        {
            BookingForm booking = new BookingForm();
            booking.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();
        }

        private void btnViewBooking_Click(object sender, EventArgs e)
        {
            ViewBooking View=new ViewBooking();
            View.Show();
            this.Hide();
        }

        private void btnLoginout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
