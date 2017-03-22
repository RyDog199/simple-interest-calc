using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterestCalculator
{
    public partial class Form1 : Form
    {
        bool IsNumber(string text)
        { 
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p;// = Convert.ToDouble(principal.Text);
            double r;// = Convert.ToDouble(rate.Text);
            double t;
            double i;
            double mp;
            double tp;


            if (principal.Text == "")
            {
                MessageBox.Show("Please fill in principal.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (rate.Text == "")
            {
                MessageBox.Show("Please fill in rate.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (time.Text == "")
            {
                MessageBox.Show("Please fill in time.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!monthRadio.Checked && !yearRadio.Checked)
            {
                MessageBox.Show("Please select a time period.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (IsNumber(principal.Text) == true && rate.Text != "" && principal.Text != "")
            {
                p = Convert.ToDouble(principal.Text);
                if (IsNumber(rate.Text) == true)
                {
                    r = Convert.ToDouble(rate.Text);
                    if (IsNumber(time.Text) == true)
                    {
                        t = Convert.ToDouble(time.Text);
                        r /= 100;
                        i = p * ( 1 + r * t);
                        interest.Text = "$" + String.Format("{0:#,##0.##}", i);
                        tp = i + p;
                        totalPaid.Text = "$" + String.Format("{0:#,##0.##}", tp);
                        if (monthRadio.Checked)
                        {
                            mp = tp / t;
                            monthlyPaid.Text = "$" + String.Format("{0:#,##0.##}", mp);
                        }
                        if (yearRadio.Checked)
                        {
                            mp = tp / (12 * t);
                            monthlyPaid.Text = "$" + String.Format("{0:#,##0.##}", mp);
                        }
                    }
                    else
                    {
                        MessageBox.Show("That's not a number, silly!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (IsNumber(principal.Text) == false && rate.Text != "" && principal.Text != "")
            {
                MessageBox.Show("That's not a number, silly!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void principal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
