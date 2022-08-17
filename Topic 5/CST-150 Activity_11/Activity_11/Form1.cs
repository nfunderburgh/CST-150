using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_11
{
    public partial class Form1 : Form
    {
        private int numSidesOnDice;
        private int rollCounter = 0;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            numSidesOnDice = random.Next(4, 20);
            DiceNum1.SelectionAlignment = HorizontalAlignment.Center;
            DiceNum2.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RollDice_Click(object sender, EventArgs e)
        {
            int dice1 = rollDie();
            int dice2 = rollDie();
            DiceNum1.Text = dice1.ToString();
            DiceNum2.Text = dice2.ToString();
            rollCounter++;
            if(dice1 == 1 &&  dice2 == 1)
            {
                MessageBox.Show(" It took " + rollCounter.ToString() + " rolls to get snake eyes");
            }
        }

        /************************************************************
         * This generates a random number betwwen 1 and the number of sides on the dice
         * @returns a randome number betwwen 1 and the number of sides on the dice
         ************************************************************/
        private int rollDie()
        {
            int die = random.Next(1, numSidesOnDice);
            return die;
        }
    }
}
