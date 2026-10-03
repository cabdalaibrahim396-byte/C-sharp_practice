using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_chacker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtNumber.Text);

                if (number >= 1 && number <= 10)
                {
                    lblRangeDecision.Text = "The number is in the range.";
                }
                else
                {
                    lblRangeDecision.Text = "The number is out of range.";
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            lblRangeDecision.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        
        }
    }
}
