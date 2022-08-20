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
    public partial class RollingDice : Form
    {
        private int sidesCount;
        private int rollCounter = 0;
        private Random random;

        public RollingDice()
        {
            InitializeComponent();
            sidesCount = 7;
            random = new Random();
            DiceNum1.SelectionAlignment = HorizontalAlignment.Center;
            DiceNum2.SelectionAlignment = HorizontalAlignment.Center;
        }
        public RollingDice(int sidesCount)
        {
            if (sidesCount <= 4 || sidesCount > 20)
            {
                this.sidesCount = 7;

            }
            else
            {
                this.sidesCount = sidesCount;
            }
            this.sidesCount++;
            random = new Random();
        }

        private void RollDice_Click(object sender, EventArgs e)
        {
            RollingDice dice = new RollingDice(10);
            int dice1 = dice.rollDie();
            int dice2 = dice.rollDie();
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
            return random.Next(1, sidesCount);
        }
    }
}
