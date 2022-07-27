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

        private void Label(object sender, EventArgs e)
        {
            Console.WriteLine("Label!");
        }

        private void Click_This(object sender, EventArgs e)
        {
            Console.WriteLine("Button!");
        }

        private void Date(object sender, EventArgs e)
        {
            Console.WriteLine("Date!");
        }

        private void CheckBox(object sender, EventArgs e)
        {
            Console.WriteLine("CheckBox!");
        }
    }
}
