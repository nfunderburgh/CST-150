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

        private void NumberTermsTextbox_TextChanged(object sender, EventArgs e)
        {
            double numberOfTermsForPi;
            double pi = 0;
            double oddNums = 1;
            int four = 4;
            int two = 2;

            //Formula used (4/1) - (4/3) + (4/5) -(4/7) ...
            try
            {
                numberOfTermsForPi = double.Parse(NumberTermsTextbox.Text);
                for (int i = 0; i < numberOfTermsForPi; i++)
                {
                    //Odd
                    if (i % 2 == 1)
                    {
                        pi = pi - (four / oddNums);
                    }
                    //Even
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

