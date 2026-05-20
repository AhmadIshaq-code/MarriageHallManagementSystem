using MY_Class_Project.Database;
using MY_Class_Project.Forms;
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

namespace MY_Class_Project
{
    public partial class LoginForm : Form
    {

        

        public LoginForm()
        {
            InitializeComponent();
            
            
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {

            LoginDB db = new LoginDB();

            DataTable dt = db.LoginStaff(txtUsername.Text);

            if (dt.Rows.Count > 0)
            {
                string enteredPassword = txtPassword.Text;

                string dbPassword =
                    dt.Rows[0]["StaffPassword"].ToString();

                bool check =
                    BCrypt.Net.BCrypt.Verify(
                        enteredPassword,
                        dbPassword
                    );

                if (check)
                {
                    MainForm main = new MainForm();

                    main.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
            else
            {
                MessageBox.Show("User Not Found");
            }
        }

       

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        
            private void lblAdmin_Click(object sender, EventArgs e)
        {
            AdminForm a = new AdminForm();
            a.Show();
            this.Hide();
        }

        private void lblAdmin_Click(object sender, MouseEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
