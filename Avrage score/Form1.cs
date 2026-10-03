using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avrage_score
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblAverage_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double score1, score2, score3, average;

            score1 = double.Parse(txtScore1.Text);
            score2 = double.Parse(txtScore2.Text);
            score3 = double.Parse(txtScore3.Text);

            average = (score1 + score2 + score3) / 3;

            if (average >= 90)
            {
                lblAverage.Text = "Excellent: " + average.ToString("0.0");
            }
            else if (average >= 80)
            {
                lblAverage.Text = "Very Good: " + average.ToString("0.0");
            }
            else if (average >= 70)
            {
                lblAverage.Text = "Good: " + average.ToString("0.0");
            }
            else if (average >= 60)
            {
                lblAverage.Text = "Pass: " + average.ToString("0.0");
            }
            else
            {
                lblAverage.Text = "Fail: " + average.ToString("0.0");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
            lblAverage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
