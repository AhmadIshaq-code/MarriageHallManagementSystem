using MY_Class_Project.Database;
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
using MY_Class_Project.Models;


namespace MY_Class_Project.Forms
{
    public partial class StaffForm : Form
    {

        int selectedId = 0;

        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            LoadStaff();
            

        }

        private void LoadStaff()
        {
            StaffDB db = new StaffDB();
            dataGridView1.DataSource = db.GetStaff();



            // 🔥 STYLE START

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 30;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;

            // Column rename (optional)
            dataGridView1.Columns["StaffName"].HeaderText = "Name";
            dataGridView1.Columns["StaffPhone"].HeaderText = "Phone";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Staff s = new Staff()
            {
                StaffName = txtName.Text,
                StaffPhone = txtPhone.Text,
                StaffGender = cmbGender.Text,
                StaffPassword = txtPassword.Text
            };

            StaffDB db = new StaffDB();
            db.AddStaff(s);

            MessageBox.Show("Staff Added");

            LoadStaff();
            ResetFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Staff s = new Staff()
            {
                StaffId = selectedId,
                StaffName = txtName.Text,
                StaffPhone = txtPhone.Text,
                StaffGender = cmbGender.Text,
                StaffPassword = txtPassword.Text
            };

            StaffDB db = new StaffDB();
            db.UpdateStaff(s);

            MessageBox.Show("Staff Updated Successfully");

            LoadStaff();
            ResetFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StaffDB db = new StaffDB();
            db.DeleteStaff(selectedId);

            MessageBox.Show("Staff Deleted");

            LoadStaff();
            ResetFields();
        }
        

        

        private void ResetFields()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
            cmbGender.SelectedIndex = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StaffId"].Value);

            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["StaffName"].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["StaffPhone"].Value.ToString();
            cmbGender.Text = dataGridView1.Rows[e.RowIndex].Cells["StaffGender"].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells["StaffPassword"].Value.ToString();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login=new LoginForm();
            login.Show();
            
        }
    }
    
}


