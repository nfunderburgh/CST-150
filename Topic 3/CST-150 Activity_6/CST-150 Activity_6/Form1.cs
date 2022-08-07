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
            // Weight on Mars = (Weight on Earth / 9.81) * 3.711
            double earthsGravityForce = 9.81;
            double marsGravityForce = 3.711;
            try
            {
                double weightOnMars = double.Parse(EarthWeightTextbox.Text);
                weightOnMars = weightOnMars / earthsGravityForce;
                weightOnMars = weightOnMars * marsGravityForce;
                MarsWeightTextbox.Text = weightOnMars.ToString("N3");
            }
            catch {
                MarsWeightTextbox.Text = "Invalid data";
            }

        }
    }
}
