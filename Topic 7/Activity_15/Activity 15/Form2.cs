using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_15
{
    public partial class Form2 : Form
    {
        public Form2(Form1 frm, int total)
        {
            InitializeComponent();
            //Use assci number as seed for random number.
            Random rand = new Random(total);
            //Get next random number between 1-50
            int lucky = rand.Next(1, 50);
            // output lucky number
            this.Text = " Your lucky number is " + lucky;
            luckyNumFinalLabel.Text = " Your lucky number is " + lucky;
        }
    }
}
