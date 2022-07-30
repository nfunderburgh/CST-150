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
            try
            {
                int days = 0;
                int hours = 0; ;
                int minutes = 0;
                int aDayInSeconds = 86400;
                int aHourInSeconds = 3600;
                int aMinuteInSeconds = 60;
                int seconds = int.Parse(SecondsTextbox.Text);
                if( seconds  >= aDayInSeconds)
                {
                    days = seconds / aDayInSeconds;
                    seconds = seconds % aDayInSeconds;

                }
                if( seconds >= aHourInSeconds)
                {
                    hours = seconds / aHourInSeconds;
                    seconds = seconds % aHourInSeconds;
                }
                if (seconds >= aMinuteInSeconds)
                {
                    minutes = seconds / aMinuteInSeconds;
                    seconds = seconds % aMinuteInSeconds;
                }
                TimeOutput.Text = days.ToString() + " days " + hours.ToString() + " hours " +
                    minutes.ToString() + " minutes " + seconds.ToString() + " seconds ";
            }
            catch {
                TimeOutput.Text = "Invalid data";
            }

        }
    }
}
