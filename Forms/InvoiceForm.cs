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

namespace MY_Class_Project.Forms
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm(Booking b)
        {
            InitializeComponent();

            

            lblBookingId.Text = b.BId.ToString();
            lblCustomer.Text = b.CustName;
            lblDate.Text = b.BDate.ToShortDateString();
            lblTime.Text = b.BTime;

            lblPersons.Text = b.Persons.ToString();

            lblDishes.Text = b.Dishes;
            lblDrinks.Text = b.Drinks;

            lblFoodCost.Text = b.CostFood.ToString();
            lblDrinkCost.Text = b.CostDrink.ToString();

            lblOther.Text = b.OtherCharges.ToString();

            lblGrand.Text = b.GrdTotal.ToString();

            lblAdvance.Text = b.Advance.ToString();

            lblBalance.Text = b.Balance.ToString();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Royal Marriage Hall",
        new Font("Arial", 20, FontStyle.Bold),
        Brushes.Maroon,
        200,
        50);

            e.Graphics.DrawString("Customer: " + lblCustomer.Text,
                new Font("Arial", 12),
                Brushes.Black,
                50,
                120);

            e.Graphics.DrawString("Grand Total: " + lblGrand.Text,
                new Font("Arial", 12),
                Brushes.Black,
                50,
                160);

            e.Graphics.DrawString("Balance: " + lblBalance.Text,
                new Font("Arial", 12),
                Brushes.Black,
                50,
                200);
        }
    }
}
