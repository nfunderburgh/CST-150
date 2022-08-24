using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTacToe
{
    public partial class Form1 : Form
    {
        int[,] tictactoe = { { 2, 3, 4 },
                             { 5, 6, 7},
                             { 8, 9, 10 } };
        int turnCounter = 0;
        bool winner = false;
        public Form1()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 500;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Brush myBrush = new SolidBrush(Color.Black);
            myPen.Width = 7.0F;
            //Drawing horiziontal Lines
            g.DrawLine(myPen, 100, 200, 400, 200);
            g.DrawLine(myPen, 100, 300, 400, 300);
            //Drawing vertical Lines
            g.DrawLine(myPen, 200, 400, 200, 100);
            g.DrawLine(myPen, 300, 400, 300, 100);
        }

        private void Main(object sender, int x , int y)
        {
            string whoseTurn = " ";
            //The text inside the butt is blank place hasn't been picked yet
            // If it isn't blank then we can't let the player pick that spot because its already picked
            if (tictactoe[x,y] != 1 && tictactoe[x, y] != 0)
            {
                if (turnCounter % 2 == 0)
                {
                    whoseTurn = "Player 2";
                    turnLabel.Text = whoseTurn + " Turn!";
                    ((Button)sender).Text = "X";
                    tictactoe[x, y] = 1;
                }
                else
                {
                    whoseTurn = "Player 1";
                    turnLabel.Text = whoseTurn + " Turn!";
                    ((Button)sender).Text = "O";
                    tictactoe[x, y] = 0;
                }
                turnCounter++;
                winner = winConditions();
                if (winner)
                {
                    if (turnCounter % 2 == 0)
                    {
                        turnLabel.Text = "Player 2 Winner";
                        MessageBox.Show("Player 2 Winner");
                        reset();
                    }
                    else
                    {
                        turnLabel.Text = "Player 1 Winner";
                        MessageBox.Show("Player 1 Winner");
                        reset();
                    }
                }
                // if we reach 9 and there is no winner then its a tie game
                if (turnCounter == 9 && winner != true)
                {
                    MessageBox.Show("Tie Game");
                    reset();
                }
            }
            else
            {
                MessageBox.Show("Pick a different place!");
            }
        }
        private void reset()
        {
            turnCounter = 0;
            winner = false;
            int counter = 1;
            for( int i = 0; i <= 2; i++)
            {
                for(int j = 0; j <= 2; j++)
                {
                    counter++;
                    tictactoe[i, j] = counter;
                }
            }
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            turnLabel.Text = "Select a square";
        }

        private bool winConditions()
        {   
            //Winning condition for first horizontal row
            if (tictactoe[0,0] == tictactoe[0,1] && tictactoe[0,1] == tictactoe[0, 2])
            {
                return true;
            }
            //Winning condition for second horizontal row
            else if (tictactoe[1, 0] == tictactoe[1, 1] && tictactoe[1, 1] == tictactoe[1, 2])
            {
                return true;
            }
            //Winning condition for third horizontal row
            else if (tictactoe[2, 0] == tictactoe[2, 1] && tictactoe[2, 1] == tictactoe[2, 2])
            {
                return true;
            }
            //Winning condition for first column
            else if (tictactoe[0, 0] == tictactoe[1, 0] && tictactoe[1, 0] == tictactoe[2, 0])
            {
                return true;
            }
            //Winning condition for second column
            else if (tictactoe[0, 1] == tictactoe[1, 1] && tictactoe[1, 1] == tictactoe[2, 1])
            {
                return true;
            }
            //Winning condition for third column
            else if (tictactoe[0, 2] == tictactoe[1,2] && tictactoe[1,2] == tictactoe[2, 2])
            {
                return true;
            }
            //Diagonal winning conditions
            else if (tictactoe[0, 0] == tictactoe[1, 1] && tictactoe[1, 1] == tictactoe[2, 2])
            {
                return true;
            }
            else if (tictactoe[0, 2] == tictactoe[1, 1] && tictactoe[1, 1] == tictactoe[2, 0])
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            Main(sender,0,0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main(sender,0,1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main(sender,0,2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main(sender,1,0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main(sender,1,1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Main(sender,1,2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Main(sender,2,0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Main(sender,2,1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Main(sender,2,2);
        }
    }
}
