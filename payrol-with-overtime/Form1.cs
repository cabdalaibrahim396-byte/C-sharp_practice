using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payrol_with_overtime
{
    public partial class Form1 : Form
    {
        // Constructor for the form
        public Form1()
        {
            // Initialize all form controls
            InitializeComponent();
        }

        // This method runs when the Calculate button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            double hoursWorked;
            double hourlyPayRate;

            // Check whether the hours worked field is empty
            if (hoursWorkedTextBox.Text == "")
            {
                MessageBox.Show("Please enter hours worked.");
            }
            else
            {
                // Check whether the hourly pay rate field is empty
                if (hourlyPayRateTextBox.Text == "")
                {
                    MessageBox.Show("Please enter hourly pay rate.");
                }
                else
                {
                    // Convert the hours worked input into a double value
                    if (!double.TryParse(hoursWorkedTextBox.Text, out hoursWorked))
                    {
                        MessageBox.Show("Please enter valid hours worked.");
                    }
                    else
                    {
                        // Convert the hourly pay rate input into a double value
                        if (!double.TryParse(
                            hourlyPayRateTextBox.Text,
                            out hourlyPayRate))
                        {
                            MessageBox.Show("Please enter valid hourly pay rate.");
                        }
                        else
                        {
                            double grossPay;

                            // Calculate regular pay if the employee worked
                            // 40 hours or less
                            if (hoursWorked <= 40)
                            {
                                grossPay = hoursWorked * hourlyPayRate;
                            }
                            else
                            {
                                // Calculate the number of overtime hours
                                double overtimeHours = hoursWorked - 40;

                                // Calculate overtime pay at 1.5 times
                                // the regular hourly pay rate
                                double overtimePay =
                                    overtimeHours * hourlyPayRate * 1.5;

                                // Add regular pay for 40 hours to overtime pay
                                grossPay = (40 * hourlyPayRate) + overtimePay;
                            }

                            // Display the gross pay as currency
                            lblgrosspay.Text = grossPay.ToString("C");
                        }
                    }
                }
            }
        }

        // This method runs when the Clear button is clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the gross pay label
            lblgrosspay.Text = "";
        }

        // This method runs when the Exit button is clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the application window
            this.Close();
        }
    }
}
