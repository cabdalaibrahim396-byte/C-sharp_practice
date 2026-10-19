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

namespace Airpline_ticket_booking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbnormal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            // Variables
            int PassengerAge;
            int NumberTicket;
            double Baggageweight;

            string bookingApproved = "";

            string Passengername = txtname.Text;

            if (Passengername == "")
            {
                MessageBox.Show("Soo Geli Magaca Rakaabka");
            }
            else
            {
                if (int.TryParse(txtage.Text, out PassengerAge) && double.TryParse(txtbaggage.Text, out Baggageweight))
                {
                    PassengerAge = int.Parse(txtage.Text);
                    NumberTicket = int.Parse(txttickets.Text);
                    Baggageweight = double.Parse(txtbaggage.Text);

                    // Travel Class
                    double ticketPrice = 0;
                    string TicketClass = "";

                    if (rbfistclass.Checked)
                    {
                        ticketPrice = 200;
                        TicketClass = "First Class";
                    }
                    else if (rbnormal.Checked)
                    {
                        ticketPrice = 100;
                        TicketClass = "Normal Class";
                    }
                    else if (rbbusiness.Checked)
                    {
                        ticketPrice = 300;
                        TicketClass = "Business Class";
                    }
                    else
                    {
                        MessageBox.Show("Fadlan dooro Travel Class kaaga");
                    }

                    // Basic Ticket Cost
                    double basicTicketCost = ticketPrice * NumberTicket;

                    // Ticket Discount
                    double ticketDiscount = 0;

                    if (NumberTicket >= 3 && NumberTicket <= 4)
                    {
                        ticketDiscount = basicTicketCost * 0.05;
                    }
                    else if (NumberTicket == 5)
                    {
                        ticketDiscount = basicTicketCost * 0.10;
                    }

                    // Age Discount
                    double ageDiscount = 0;

                    if (PassengerAge < 12)
                    {
                        ageDiscount = basicTicketCost * 0.20;
                    }
                    else if (PassengerAge >= 60)
                    {
                        ageDiscount = basicTicketCost * 0.10;
                    }

                    // Total Discount
                    double Discount = ticketDiscount + ageDiscount;

                    // Travel Insurance
                    double Insurance_Cost = 0;

                    if (cbinsurence.Checked)
                    {
                        Insurance_Cost = 25 * NumberTicket;
                    }


                    // Free Baggage Allowance
                    double freeBaggageLimit = 20 * NumberTicket;

                    double excessBaggage = 0;

                    if (Baggageweight > freeBaggageLimit)
                    {
                        excessBaggage = Baggageweight - freeBaggageLimit;
                    }


                    // Total Cost
                    double Total_Cost = basicTicketCost - Discount + Insurance_Cost;

                    // 2 Passenger Age
                    if (PassengerAge >= 1 && PassengerAge <= 100)
                    {
                        // 1 
                        if (int.TryParse(txttickets.Text, out NumberTicket))
                        {
                            // 3 Number of Tickets 
                            if (NumberTicket >= 1 && NumberTicket <= 5)
                            {
                                // 4 Baggage Weight
                                if (Baggageweight >= 0 && Baggageweight <= 50)
                                {


                                    // 6 Booking Approval
                                    if (PassengerAge < 12 && rbfistclass.Checked)
                                    {
                                        MessageBox.Show("Reason : waxaad dooratay first class age kaaguna wuxuu ka yaryahay 12");
                                        bookingApproved = "rejected";
                                        listBox1.Items.Add("Booking Details");
                                        listBox1.Items.Add(" ");
                                        listBox1.Items.Add("Passenger Name: " + Passengername);
                                        listBox1.Items.Add("Passenger Age: " + PassengerAge);
                                        listBox1.Items.Add("Number of Tickets: " + NumberTicket);
                                        listBox1.Items.Add("Ticket Class: " + TicketClass);
                                        listBox1.Items.Add("Baggage Weight: " + Baggageweight);
                                        listBox1.Items.Add(" ");

                                        listBox1.Items.Add("Booking status: " + bookingApproved);
                                    }
                                    else
                                    {
                                        bookingApproved = "Approved";

                                        listBox1.Items.Add("Booking Details");
                                        listBox1.Items.Add(" ");
                                        listBox1.Items.Add("Passenger Name: " + Passengername);
                                        listBox1.Items.Add("Passenger Age: " + PassengerAge);
                                        listBox1.Items.Add("Number of Tickets: " + NumberTicket);
                                        listBox1.Items.Add("Ticket Class: " + TicketClass);
                                        listBox1.Items.Add("Baggage Weight: " + Baggageweight);
                                        listBox1.Items.Add("Free Baggage Allowance: " + freeBaggageLimit + " kg");
                                        listBox1.Items.Add("Excess Baggage: " + excessBaggage);
                                        listBox1.Items.Add("Basic Ticket Cost: $" + basicTicketCost);
                                        listBox1.Items.Add("Ticket Discount: $" + ticketDiscount);
                                        listBox1.Items.Add("Age Discount: $" + ageDiscount);
                                        listBox1.Items.Add("Total Discount: $" + Discount);
                                        listBox1.Items.Add("Insurance Cost: $" + Insurance_Cost);
                                        listBox1.Items.Add(" ");
                                        listBox1.Items.Add("Total Cost: $" + Total_Cost);
                                        listBox1.Items.Add(" ");
                                        listBox1.Items.Add("Booking status: " + bookingApproved);

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Baggage weight ma noqon karo negative, " + "mana dhaafi karo 50 kg qofkiiba");

                                }
                            }

                            else
                            {
                                MessageBox.Show("Tickets ku waa inay u dhexeeyaan 1 ilaa 5");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Soo Geli Number of Tickets sax ah");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Age waa inuu u dhexeeyaa 1 ilaa 100");

                    }
                }
                else
                {
                    MessageBox.Show("Soo geli Age sax ah");

                }
            }
        }

    

        
        
        
          

        private void btnclear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
           this. Close();
        }
    }
}


