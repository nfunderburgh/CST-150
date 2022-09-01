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
            Random rand = new Random(total);
            int lucky = rand.Next(1, 50);
            luckyNumFinalLabel.Text = " Your lucky number is " + lucky;
        }
    }
}
