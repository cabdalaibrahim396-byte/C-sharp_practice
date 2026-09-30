using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string guestName = txtGuestName.Text;
                string roomType = txtRoomType.Text;

                int nights = int.Parse(txtNights.Text);
                double pricePerNight = double.Parse(txtPriceNight.Text);

                double totalCost = nights * pricePerNight;

                double serviceTax = totalCost * 0.10;
                double discount = totalCost * 0.05;

                double totalAmount = (totalCost * 2) + serviceTax - discount;

                lblServiceTax.Text = serviceTax.ToString("C");
                lblDiscount.Text = discount.ToString("C");
                lblTotalAmount.Text = totalAmount.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for nights and price.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
