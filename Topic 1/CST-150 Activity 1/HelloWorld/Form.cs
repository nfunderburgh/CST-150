using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Click_This(object sender, EventArgs e)
        {
            textBox1.Text = "Button was pressed!";
        }

        private void checkBox_Checked(object sender, EventArgs e)
        {
            textBox1.Text = "Checkbox is checked!";
        }

        private void dateTime_Picker(object sender, EventArgs e)
        {
            textBox1.Text = "Date has been picked!";
        }

        private void radioButton_Selected(object sender, EventArgs e)
        {
            textBox1.Text = "Radio button was selected!";
        }

        private void label_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Label was pressed!";
        }
    }
}
