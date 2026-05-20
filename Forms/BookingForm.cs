using MY_Class_Project.Database;
using MY_Class_Project.Models;
using System;
using System.Data;
using System.Windows.Forms;


namespace MY_Class_Project.Forms
{
    public partial class BookingForm : Form
    {
        DataTable customerTable;
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        // ================= CUSTOMER LOAD =================
        private void LoadCustomers()
        {
            CustomerDB db = new CustomerDB();

            customerTable = db.GetCustomers();

            comboCustomer.DataSource = customerTable;
            comboCustomer.DisplayMember = "CustId";
            comboCustomer.ValueMember = "CustId";
        }

        // ================= LABEL SYNC =================
        private void comboCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboCustomer.SelectedValue == null) return;

            int id = Convert.ToInt32(comboCustomer.SelectedValue);

            DataRow[] row = customerTable.Select("CustId = " + id);

            if (row.Length > 0)
            {
                lblCustomerName.Text = row[0]["CustName"].ToString();
            }
        }


        // ================= FOOD CALCULATE =================
        private void btnFoodCalculate_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (chkMutton.Checked)
            {
                total += Convert.ToInt32(txtMuttonPrice.Text)
                      * Convert.ToInt32(txtMuttonQty.Text);
            }

            if (chkChicken.Checked)
            {
                total += Convert.ToInt32(txtChickenPrice.Text)
                      * Convert.ToInt32(txtChickenQty.Text);
            }

            if (chkFish.Checked)
            {
                total += Convert.ToInt32(txtFishPrice.Text)
                      * Convert.ToInt32(txtFishQty.Text);
            }

            if (chkBiryani.Checked)
            {
                total += Convert.ToInt32(txtBiryaniPrice.Text)
                      * Convert.ToInt32(txtBiryaniQty.Text);
            }

            if (chkKebab.Checked)
            {
                total += Convert.ToInt32(txtKebabPrice.Text)
                      * Convert.ToInt32(txtKebabQty.Text);
            }

            lblFoodCost.Text = total.ToString();
        }

        // ================= DRINK CALCULATE =================
        private void btnDrinkCalculate_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (chkCola.Checked)
            {
                total += Convert.ToInt32(txtColaPrice.Text)
                      * Convert.ToInt32(txtColaQty.Text);
            }

            if (chk7up.Checked)
            {
                total += Convert.ToInt32(txt7upPrice.Text)
                      * Convert.ToInt32(txt7upQty.Text);
            }

            if (chkSprite.Checked)
            {
                total += Convert.ToInt32(txtSpritePrice.Text)
                      * Convert.ToInt32(txtSpriteQty.Text);
            }

            if (chkJuice.Checked)
            {
                total += Convert.ToInt32(txtJuicePrice.Text)
                      * Convert.ToInt32(txtJuiceQty.Text);
            }

            if (chkWater.Checked)
            {
                total += Convert.ToInt32(txtWaterPrice.Text)
                      * Convert.ToInt32(txtWaterQty.Text);
            }

            lblDrinkCost.Text = total.ToString();
        }


        // ================= TOTAL CALC =================
        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            int drink = Convert.ToInt32(lblDrinkCost.Text);
            int food = Convert.ToInt32(lblFoodCost.Text);
            int other = Convert.ToInt32(txtOtherCharges.Text);
            int advance = Convert.ToInt32(txtAdvance.Text);

            int grandTotal = drink + food + other;
            int balance = grandTotal - advance;

            txtGrandTotal.Text = grandTotal.ToString();
            txtBalance.Text = balance.ToString();
        }

        // ================= GET DRINKS =================
        private string GetSelectedDrinks()
        {
            string drinks = "";

            if (chkCola.Checked) drinks += "Cola,";
            if (chkJuice.Checked) drinks += "Juice,";
            if (chkWater.Checked) drinks += "Water,";
            if (chkSprite.Checked) drinks += "Sprite,";
            if (chk7up.Checked) drinks += "7up,";

            return drinks;
        }

        // ================= GET DISHES =================
        private string GetSelectedDishes()
        {
            string dishes = "";

            if (chkChicken.Checked) dishes += "Chicken,";
            if (chkMutton.Checked) dishes += "Mutton,";
            if (chkFish.Checked) dishes += "Fish,";
            if (chkBiryani.Checked) dishes += "Biryani,";
            if (chkKebab.Checked) dishes += "Kebab,";

            return dishes;
        }

        // ================= RESET =================
        private void ResetForm()
        {
            txtPersons.Clear();
            txtOtherCharges.Clear();
            txtAdvance.Clear();
            txtGrandTotal.Clear();
            txtBalance.Clear();

            lblDrinkCost.Text = "0";
            lblFoodCost.Text = "0";
        }

        // ================= ADD BOOKING =================
        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            Booking b = new Booking();

            DataRowView row = comboCustomer.SelectedItem as DataRowView;

            if (row != null)
            {
                b.CustId = Convert.ToInt32(row["CustId"]);
                b.CustName = row["CustName"].ToString();
            }

            b.BDate = dateTimePicker1.Value;
            b.BTime = cmbTime.Text;

            b.Persons = Convert.ToInt32(txtPersons.Text);

            b.Dishes = GetSelectedDishes();
            b.Drinks = GetSelectedDrinks();

            b.CostDrink = Convert.ToInt32(lblDrinkCost.Text);
            b.CostFood = Convert.ToInt32(lblFoodCost.Text);

            b.OtherCharges = Convert.ToInt32(txtOtherCharges.Text);
            b.GrdTotal = Convert.ToInt32(txtGrandTotal.Text);

            b.Advance = Convert.ToInt32(txtAdvance.Text);
            b.Balance = Convert.ToInt32(txtBalance.Text);

            BookingDB db = new BookingDB();

            db.AddBooking(b);

            MessageBox.Show("Booking Saved");

            ResetForm();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();

        }
    }
}