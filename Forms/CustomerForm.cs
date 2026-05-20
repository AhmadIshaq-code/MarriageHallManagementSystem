using MY_Class_Project.Database;
using MY_Class_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MY_Class_Project.Forms
{
    public partial class CustomerForm : Form
    {
        int selectedId = 0;
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

            LoadCustomers();

        }

        private void LoadCustomers()
        {
            CustomerDB db = new CustomerDB();

            DataTable dt = db.GetCustomers();

            dataGridView1.DataSource = null;   // IMPORTANT

            dataGridView1.DataSource = dt;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CustId"].Value);

                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["CustName"].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["CustAdd"].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["CustPhone"].Value.ToString();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Customer c = new Customer()
            {
                CustName = txtName.Text,
                CustAdd = txtAddress.Text,
                CustPhone = txtPhone.Text
            };

            CustomerDB db = new CustomerDB();
            db.AddCustomer(c);

            MessageBox.Show("Customer Added");

            LoadCustomers();
            ResetFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Customer c = new Customer()
            {
                CustId = selectedId,
                CustName = txtName.Text,
                CustAdd = txtAddress.Text,
                CustPhone = txtPhone.Text
            };

            CustomerDB db = new CustomerDB();
            db.UpdateCustomer(c);

            MessageBox.Show("Updated");

            LoadCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CustomerDB db = new CustomerDB();
            db.DeleteCustomer(selectedId);

            MessageBox.Show("Deleted");

            LoadCustomers();
        }

        private void ResetFields()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            
            MainForm main=new MainForm();
            main.Show();
            this.Hide();
        }

        
    }
}
