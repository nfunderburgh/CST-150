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

        private void buttonToTextBoxOutput(object sender, EventArgs e)
        {
            outputTextBox.Text = "Button was pressed!";
        }

        private void checkBoxToTextBoxOutput(object sender, EventArgs e)
        {
            outputTextBox.Text = "Checkbox is checked!";
        }

        private void dateTimeToTextBoxOutput(object sender, EventArgs e)
        {
            outputTextBox.Text = "Date has been picked!";
        }

        private void radioButtonToTextBoxOutput(object sender, EventArgs e)
        {
            outputTextBox.Text = "Radio button was selected!";
        }

        private void labelToTextBoxOutput(object sender, EventArgs e)
        {
            outputTextBox.Text = "Label was pressed!";
        }
    }
}
