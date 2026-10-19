using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_room
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // creating variables
            string name;
            int age;
            int nigts;
            int guests;

            string roomtype = "";
            string breakfast = "";

            // 1
            if (int.TryParse(txtage.Text, out age) && int.TryParse(txtnights.Text, out nigts) && int.TryParse(txtnumber.Text, out guests))
            {
                name = txtname.Text;
                age = int.Parse(txtage.Text);
                nigts = int.Parse(txtnights.Text);
                guests = int.Parse(txtnumber.Text);
                

                // room rates

                int rate_night = 0;
                if (rdstander.Checked)
                {
                    roomtype = "Standard";
                    rate_night = 50;
                } else if (rdnormal.Checked)
                {
                    roomtype = "Normal";
                    rate_night = 80;
                } else if (rdhight.Checked)
                {
                    roomtype = "Hight";
                    rate_night = 130;
                } else
                {
                    MessageBox.Show("soo dooro room type");
                }


                // calculate booking amount
                double booking_fee = nigts * rate_night;

                // cost rules

                // 1-4 no discount
                double discount_fee = 0;
                if (nigts >= 1 && nigts <= 4)
                {
                    discount_fee = 0;
                }
                // 1-4 nigts give 5%
                else if (nigts >= 5 && nigts <= 9)
                {
                    discount_fee = booking_fee * 0.05;
                } 
                // 10 or more 12% 
                else if (nigts >= 10)
                {
                    discount_fee = (booking_fee * 12) /100;
                } else
                {
                    discount_fee = 0;
                }


                // Breakfast

                double breakfast_fee = 0;
                if (cbbreakfast.Checked)
                {
                    breakfast = "You selected breakfast";
                    breakfast_fee = 10 * guests * nigts;
                } else
                {
                    breakfast = "No breakfast";
                    breakfast_fee = 0;
                }

                // subcharch
                double subcharch = 0;
                if (guests > 4)
                {
                    subcharch = booking_fee * 0.05;
                } else
                {
                    subcharch = 0;
                }

                // more than 60 age give senior discount for 5%
                double senior =0;
                if (age >= 60)
                {
                    senior = booking_fee * 0.05;
                } else
                {
                    senior = 0;
                }

                // final calculation
                double final_fee = (booking_fee + breakfast_fee + subcharch) - discount_fee - senior;


                //2
                if (name != "")
                {
                    // 3
                    if (age >= 18 && age <= 90)
                    {
                        // 4
                        if (nigts >= 1 && nigts <= 30)
                        {
                            // 5
                            if (guests >= 1 && guests <= 6)
                            {
                                // 6
                                // hight number of 6
                                // normal number of 4
                                // standard number of guest 2

                                /// 7
                                // determine booking confirm or reject
                                string booking_determine = "";

                                if (rdstander.Checked && guests > 2)
                                {
                                    booking_determine = "Rejected";
                                    MessageBox.Show("waxaa dooratay standard sidas darteed standar waxaa la ogolyahay 2 guests ama ka yar");
                                    // display
                                    listBox1.Items.Add("Guest name " + name);
                                    listBox1.Items.Add("Guest age " + age);
                                    listBox1.Items.Add("Number of night " + nigts);
                                    listBox1.Items.Add("Number of gues " + guests);
                                    listBox1.Items.Add("Room type " + roomtype);
                                    listBox1.Items.Add("Breakfasta " + breakfast);
                                    listBox1.Items.Add("Booking determination " + booking_determine);
                                }
                                else if (rdnormal.Checked && guests > 4)
                                {
                                    booking_determine = "Rejected";

                                    MessageBox.Show("waxaa dooratay Normal sidas darteed Normal waxaa la ogolyahay 4 guests ama wax ka yar");
                                    // display
                                    listBox1.Items.Add("Guest name " + name);
                                    listBox1.Items.Add("Guest age " + age);
                                    listBox1.Items.Add("Number of night " + nigts);
                                    listBox1.Items.Add("Number of gues " + guests);
                                    listBox1.Items.Add("Room type " + roomtype);
                                    listBox1.Items.Add("Breakfasta " + breakfast);
                                    listBox1.Items.Add("Booking determination " + booking_determine);
                                }
                                else if (rdhight.Checked && guests > 6)
                                {
                                    booking_determine = "Rejected";

                                    MessageBox.Show("waxaa dooratay Hiht sidas darteed Hiht waxaa la ogolyahay 6 guests ama wax ka yar");
                                    // display
                                    listBox1.Items.Add("Guest name " + name);
                                    listBox1.Items.Add("Guest age " + age);
                                    listBox1.Items.Add("Number of night " + nigts);
                                    listBox1.Items.Add("Number of gues " + guests);
                                    listBox1.Items.Add("Room type " + roomtype);
                                    listBox1.Items.Add("Breakfasta " + breakfast);
                                    listBox1.Items.Add("Booking determination " + booking_determine);

                                }
                                else
                                {
                                    booking_determine = "Approved";

                                    // display
                                    listBox1.Items.Add("Guest name " + name);
                                    listBox1.Items.Add("Guest age " + age);
                                    listBox1.Items.Add("Number of night " + nigts);
                                    listBox1.Items.Add("Number of gues " + guests);
                                    listBox1.Items.Add("Room type " + roomtype);
                                    listBox1.Items.Add("Room type rate amount " + rate_night);
                                    listBox1.Items.Add("Breakfasta " + breakfast);
                                    listBox1.Items.Add("Breakfast fee " + breakfast_fee);
                                    listBox1.Items.Add("booking fee " + booking_fee);
                                    listBox1.Items.Add("Discount " + discount_fee);
                                    listBox1.Items.Add("Discount senior " + senior);
                                    listBox1.Items.Add("Subcharge " + subcharch);
                                    listBox1.Items.Add("Total fee " + final_fee);
                                    listBox1.Items.Add("Booking determination " + booking_determine);


                                    



                                }


                            }
                            else
                            {
                                MessageBox.Show("Number of guests must b/w 1-6");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Number of nights must be 1-30");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Age ka waa inuu udhaxeeya 18-90");
                    }

                }
                else
                {
                    MessageBox.Show("name can not accept empty value");

                }


            } else
            {
                MessageBox.Show("age, nigts, guest only excepts numeric values");
            }


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
