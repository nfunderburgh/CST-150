using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shape_Maker
{
    public partial class Form1 : Form
    {
        bool clearGraphics = false;
        public Form1()
        {
            InitializeComponent();
            nameLabel.Text = "";
            dateLabel.Text = "";
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            //Date
            if (dateCheckBox.Checked)
            {
                DateTime thisDay = DateTime.Today;
                dateLabel.Text = thisDay.ToString("d");
            }
            else
            {
                dateLabel.Text = "";
            }
            //Name
            if (nameCheckBox.Checked)
            {
                nameLabel.Text = listBox1.SelectedItem.ToString();
            }
            else
            {
                nameLabel.Text = "";
            }
            this.Refresh();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearGraphics = true;
            this.Refresh();
            clearGraphics = false;
        }

        private void main_Paint(object sender, PaintEventArgs e)
        {
            string selectedShape = "";
            if (listBox1.SelectedIndex != -1 )
            {
                selectedShape = listBox1.SelectedItem.ToString();
            }
            switch (selectedShape)
            {
                case "Circle":
                    circle_Paint(this, e);
                    break;
                case "Triangle":
                    triangle_Paint(this, e);
                    break;
                case "Rectangle":
                    rectangle_Paint(this, e);
                    break;
                case "Pentagon":
                    pentagon_Paint(this, e);
                    break;
                case "Hexagon":
                    hexagon_Paint(this, e);
                    break;
            }
            if(clearGraphics)
            {
                e.Graphics.Clear(Color.White);
            }
        }

        private void circle_Paint(object sender, PaintEventArgs e)
        {
            if (outlineRadioButton.Checked)
            {
                Graphics g = e.Graphics;
                Pen blackPen = new Pen(Color.Black, 4);
                g.DrawEllipse(blackPen, 50, 50, 100, 100);
            }
            if (fillRadioButton.Checked)
            {
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                e.Graphics.FillEllipse(blackBrush, 50, 50, 100, 100);
            }
        }

        private void triangle_Paint(object sender, PaintEventArgs e)
        {
            if (outlineRadioButton.Checked)
            {
                Pen blackPen = new Pen(Color.Black, 4);
                e.Graphics.DrawLine(blackPen, 150, 150, 100, 50);
                e.Graphics.DrawLine(blackPen, 100, 50, 50, 150);
                e.Graphics.DrawLine(blackPen, 150, 150, 50, 150);
            }
            if (fillRadioButton.Checked)
            {
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                Point point1 = new Point(150, 150);
                Point point2 = new Point(50, 150);
                Point point3 = new Point(100, 50);
                Point[] curvePoints = { point1, point2, point3 };
                e.Graphics.FillPolygon(blackBrush, curvePoints);
            }
        }

        private void rectangle_Paint(object sender, PaintEventArgs e)
        {
            if (outlineRadioButton.Checked)
            {
                Pen blackPen = new Pen(Color.Black, 4);
                e.Graphics.DrawLine(blackPen, 50, 50, 150, 50);
                e.Graphics.DrawLine(blackPen, 50, 50, 50, 150);
                e.Graphics.DrawLine(blackPen, 150, 150, 50, 150);
                e.Graphics.DrawLine(blackPen, 150, 150, 150, 50);
            }
            if (fillRadioButton.Checked)
            {
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                Rectangle rect = new Rectangle(50, 50, 100, 100);
                e.Graphics.FillRectangle(blackBrush, rect);
            }
        }

        private void pentagon_Paint(object sender, PaintEventArgs e)
        {
            if (outlineRadioButton.Checked)
            {
                Pen blackPen = new Pen(Color.Black, 4);

                e.Graphics.DrawLine(blackPen, 125, 150, 75, 150);
                e.Graphics.DrawLine(blackPen, 75, 150, 50, 100);
                e.Graphics.DrawLine(blackPen, 50, 100, 100, 50);
                e.Graphics.DrawLine(blackPen, 100, 50, 150, 100);
                e.Graphics.DrawLine(blackPen, 125, 150, 150, 100);

            }
            if (fillRadioButton.Checked)
            {
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                Point point1 = new Point(125, 150);
                Point point2 = new Point(75, 150);
                Point point3 = new Point(50, 100);
                Point point4 = new Point(100, 50);
                Point point5 = new Point(150, 100);

                Point[] curvePoints = { point1, point2, point3, point4, point5 };
                e.Graphics.FillPolygon(blackBrush, curvePoints);
            }
        }
        private void hexagon_Paint(object sender, PaintEventArgs e)
        {
            if (outlineRadioButton.Checked)
            {
                Pen blackPen = new Pen(Color.Black, 4);

                e.Graphics.DrawLine(blackPen, 125, 150, 75, 150);
                e.Graphics.DrawLine(blackPen, 75, 150, 50,100);
                e.Graphics.DrawLine(blackPen, 50, 100, 75, 50);
                e.Graphics.DrawLine(blackPen, 75, 50, 125, 50);
                e.Graphics.DrawLine(blackPen, 125, 50, 150, 100);
                e.Graphics.DrawLine(blackPen, 150, 100, 125, 150);


            }
            if (fillRadioButton.Checked)
            {
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                Point point1 = new Point(125, 150);
                Point point2 = new Point(75, 150);
                Point point3 = new Point(50, 100);
                Point point4 = new Point(75, 50);
                Point point5 = new Point(125, 50);
                Point point6 = new Point(150, 100);

                Point[] curvePoints = { point1, point2, point3, point4, point5, point6 };
                e.Graphics.FillPolygon(blackBrush, curvePoints);
            }
        }

        private void nameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Name
            if (nameCheckBox.Checked)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    nameLabel.Text = listBox1.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a shape");
                    nameCheckBox.Checked = false;
                }
            }
            else
            {
                nameLabel.Text = "";
            }
        }

        private void dateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Date
            if (dateCheckBox.Checked)
            {
                DateTime thisDay = DateTime.Today;
                dateLabel.Text = thisDay.ToString("d");
            }
            else
            {
                dateLabel.Text = "";
            }
        }
    }
}
