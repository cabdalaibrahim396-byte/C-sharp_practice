using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            /// creating variabls
            string name;
            int age;
            int Number_of_rental_days;
            int Years_of_Experience;
            string vehicle_Type = "";

            // converting  trty parse
            if (int.TryParse(txtage.Text, out age) &&
                int.TryParse(txtnumber.Text, out Number_of_rental_days) &&
                int.TryParse(txtexperience.Text, out Years_of_Experience))
            {
                name = txtname.Text; // textbox-ka magaca


                // varible of daily rate 

                int Daily_rate = 0;

                if (rdeconomy.Checked)
                {
                    vehicle_Type = "Economy";
                    Daily_rate = 35;
                }
                else if (rdsuv.Checked)
                {
                    vehicle_Type = "SUV";
                    Daily_rate = 60;
                }
                else if (rdluxury.Checked)
                {
                    vehicle_Type = "Luxury";
                    Daily_rate = 100;
                }
                else
                {
                    MessageBox.Show("Fadlan dooro nooca gaariga.");
                    return;
                }

                // Rent Fee
                double rent_fee = Number_of_rental_days * Daily_rate;

                // Discount
                double Discount = 0;

                if (Number_of_rental_days >= 7 &&
                    Number_of_rental_days <= 13)
                {
                    Discount = rent_fee * 0.05;
                }
                else if (Number_of_rental_days >= 14)
                {
                    Discount = rent_fee * 0.10;
                }

                // Insurance
                double insurance = 0;

                if (cbinsurance.Checked)
                {
                    insurance = Number_of_rental_days * 15;
                }

                // Young Driver Surcharge
                double Young_driver_surcharge = 0;

                if (age >= 21 && age <= 24)
                {
                    Young_driver_surcharge = rent_fee * 0.10;
                }

                // Age Validation
                if (age >= 18 && age <= 80)
                {
                    if (Number_of_rental_days >= 1 &&
                        Number_of_rental_days <= 30)
                    {
                        if (Years_of_Experience >= 1)
                        {
                            if (rdluxury.Checked)
                            {
                                if (age < 25 || Years_of_Experience < 3)
                                {
                                    MessageBox.Show(
                                        "Luxury vehicle waxaa kireysan kara qof da'diisu tahay ugu yaraan 25 sano isla markaana leh 3 sano oo driving experience ah.");
                                    return;
                                }
                            }

                            // Final Cost
                            double final_cost =
                                (rent_fee + insurance + Young_driver_surcharge)
                                - Discount;

                            //// display
                            ///
                            listBox1.Items.Add("Dislpaying :");
                            listBox1.Items.Add("=============");

                            listBox1.Items.Add("Customer Name :" + name );
                            listBox1.Items.Add("Customer  Age   :" + age);
                            listBox1.Items.Add("Driven experince  :" + Years_of_Experience);
                            listBox1.Items.Add("Vehicle Type :" + vehicle_Type);
                            listBox1.Items.Add("Daily Rate :" + Daily_rate);
                            listBox1.Items.Add("Basic cost  :" + rent_fee);
                            listBox1.Items.Add("Discount  :" + Discount);
                            listBox1.Items.Add("Insurence Cost  :" + insurance);
                            listBox1.Items.Add("Your Driven surcharge :" + Young_driver_surcharge);
                            listBox1.Items.Add("Final cost  :" + final_cost);
                            

                        }
                        else
                        {
                            MessageBox.Show("Year of Experience waa inuu ka weyn yahay 0.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rental days waa inuu u dhexeeyaa 1 ilaa 30 maalmood.");
                    }
                }
                else
                {
                    MessageBox.Show("Da'da waa inay u dhexeysaa 18 ilaa 80 sano.");
                }
            }
            else
            {
                MessageBox.Show("Accept only numeric values.");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            ///exit button 
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clear of list box 
            listBox1.Items.Clear();
        }
    }
}
