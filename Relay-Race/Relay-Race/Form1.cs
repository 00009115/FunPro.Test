using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relay_Race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var runner1 = tbxRunner1.Text;
            var runner2 = tbxRunner2.Text;

            if(IsValid(runner1) && IsValid(runner2))
            {
                var totalTime = TimeSpan.Parse(runner1).Add(TimeSpan.Parse(runner2));
                MessageBox.Show("Total time is: " + totalTime);
            }
            else
            {
                MessageBox.Show("Invalid input. Please, insert a time in hh:mm format.");
            }
        }

        private bool IsValid(string input)
        {
            return DateTime.TryParse(input, out _);   
        }
    }
}
