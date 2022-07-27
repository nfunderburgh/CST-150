using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity_2
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }


        private void ConvertBtn(object sender, EventArgs e)
        {
            // Formula to calulate weight on mars
            // Weight on Mars = (Weight on Earth / 9.81) * 3.71
            try
            {
                double temp = double.Parse(EarthWeight.Text);
                temp = temp / 9.81;
                temp = temp * 3.711;
                MarsWeight.Text = temp.ToString("N6");
            }
            catch {
                MarsWeight.Text = "Invalid data";
            }

        }
    }
}
