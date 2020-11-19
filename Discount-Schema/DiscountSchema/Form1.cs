using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscountSchema
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var input = tbxAmount.Text;

            if (IsNumber(input))
            {
                var amount = Convert.ToDouble(input);
                double discountedAmount = 0;

                if (chbCard.Checked)
                {
                    if(amount < 5000)
                    {
                        discountedAmount = 0;
                    }
                    else if(amount >= 5000 && amount < 15000)
                    {
                        discountedAmount = amount * 0.015;
                    }
                    else if (amount >= 15000 && amount < 30000)
                    {
                        discountedAmount = amount * 0.025;
                    }
                    else if (amount >= 30000 && amount < 55000)
                    {
                        discountedAmount = amount * 0.035;
                    }
                    else if (amount >= 55000)
                    {
                        discountedAmount = amount * 0.045;
                    }
                }
                else
                {
                    if (amount < 10000)
                    {
                        discountedAmount = 0;
                    }
                    else if (amount >= 10000 && amount < 20000)
                    {
                        discountedAmount = amount * 0.01;
                    }
                    else if (amount >= 20000 && amount < 35000)
                    {
                        discountedAmount = amount * 0.02;
                    }
                    else if (amount >= 35000 && amount < 60000)
                    {
                        discountedAmount = amount * 0.03;
                    }
                    else if (amount >= 60000)
                    {
                        discountedAmount = amount * 0.04;
                    }
                }

                MessageBox.Show("Discounted amount is: " + discountedAmount.ToString() + " UZS");
            }
            else
            {
                MessageBox.Show("Invalid input. Please, insert in numbers");
            }
        }

        private bool IsNumber(string input)
        {
            return double.TryParse(input, out _);
        }
    }
}
