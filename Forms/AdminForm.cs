using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace MY_Class_Project.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

       

        private void btnadmincheck_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "admin123")
            {
                this.Hide();
                StaffForm sf = new StaffForm();
                sf.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
    
}
