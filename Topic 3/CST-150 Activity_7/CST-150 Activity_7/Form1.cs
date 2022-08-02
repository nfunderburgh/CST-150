using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double numberOfTermsForPi;
            double pi = 0;
            double oddNums = 1;
            int four = 4;
            int two = 4;
            try
            {
                numberOfTermsForPi = double.Parse(NumberItemsTextbox.Text);
                for (int i = 0; i < numberOfTermsForPi; i++)
                {

                    if ( i % 2 == 1)
                    {
                        pi = pi - (four / oddNums);
                    }
                    else
                    {
                        pi = pi + (four / oddNums);
                    }
                    oddNums = oddNums + two;
                }
                ApproxValueOfPi.Text = "Approximate value of pi after " + numberOfTermsForPi + " terms";
                PIValue.Text = "= " + pi.ToString();
            }
            catch
            {
                PIValue.Text = "= Invalid Data";
            }
        }
    }
}

