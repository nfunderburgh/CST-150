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
        int turn = 0;
        bool win = false;
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

        private void test(object sender, int x , int y)
        {
            Console.WriteLine(turn);
            string whoseTurn = " ";
            if (turn % 2 == 0)
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
            turn++;
            win = winConditions();
            if (win)
            {
                if(turn % 2 == 0)
                {
                    MessageBox.Show("Player 2 Winner");
                }
                else
                {
                    MessageBox.Show("Player 1 Winner");
                }
            }
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
            //Diagonal winning condition
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
            test(sender,0,0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test(sender,0,1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            test(sender,0,2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            test(sender,1,0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            test(sender,1,1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            test(sender,1,2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            test(sender,2,0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            test(sender,2,1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            test(sender,2,2);
        }
    }
}
