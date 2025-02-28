﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_15
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            //Entering in years into birth year combo box
            for (int i = 2022; i > 1910; i--)
            {
                birthYearComboBox.Items.Add(i);
            }

            group.Text = "";
        }

        // Checks if the month is change
        // If it is display the correct amount of days in that month
        private void birthMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(birthDayComboBox.Items.Count > 0)
            {
                birthDayComboBox.Items.Clear();
            }

            int daysInMonth = 0;
            string month = birthMonthComboBox.SelectedItem.ToString();
            if (month == "January" || month == "March" || month == "May" || month == "July" || month == "August" || month == "October" || month == "December")
            {
                daysInMonth = 31;
            }
            else if (month == "April" || month == "June" || month == "September" || month == "November")
            {
                daysInMonth = 30;
            }
            else if(month == "February")
            {
                string birthYear = birthYearComboBox.SelectedItem.ToString();
                if (int.Parse(birthYear) % 4 == 0)
                {
                    daysInMonth = 29;
                }
                else
                {
                    daysInMonth = 28;
                }
            }
            for (int i = 1; i <= daysInMonth; i++)
            {
                birthDayComboBox.Items.Add(i);
            }
        }
        // Checks if the current year selected is a possible leap year
        private void birthYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (birthDayComboBox.Items.Count > 0)
            {
                birthDayComboBox.Items.Clear();
            }
            int daysInMonth = 0;
            string birthYear = birthYearComboBox.SelectedItem.ToString();
            if (int.Parse(birthYear) % 4 == 0)
            {
                daysInMonth = 29;
            }
            else
            {
                daysInMonth = 28;
            }
            for (int i = 1; i <= daysInMonth; i++)
            {
                birthDayComboBox.Items.Add(i);
            }
        }
        // turns all numbered strings into integers
        // turns characters into there assci value
        // Then show the next form
        private void getLuckyNumButton_Click(object sender, EventArgs e)
        {
            int birthyear = int.Parse(birthYearComboBox.Text);
            string birthmonth = birthMonthComboBox.SelectedItem.ToString(); 
            int birthday = int.Parse(birthDayComboBox.Text);
            string favColor = favColorComboBox.SelectedItem.ToString();
            int sumBirthMonth = returnSumOfAssci(birthmonth);
            int sumFavoriteColor = returnSumOfAssci(favColor);
            int total = birthyear + birthday + sumBirthMonth + sumFavoriteColor;
            form2 = new Form2(this, total);
            this.Hide();
            form2.Show();
        }

        // takes a string and gets the sum of the char assci values
        // Returns a integer that is the sum of total assci values
        private int returnSumOfAssci(string text)
        {
            int sum = 0;
            foreach (var var in text)
            {
                sum += var;
            }

            return sum;
        }
    }
}
