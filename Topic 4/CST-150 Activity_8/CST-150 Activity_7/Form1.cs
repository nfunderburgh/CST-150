﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity_7
{
    public partial class CalorieConverter : Form
    {
        public CalorieConverter()
        {
            InitializeComponent();
        }

        private void FatGramTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int FatGrams = Int32.Parse(FatGramTextbox.Text);
                int CaloriesFromFat = FatCalories(FatGrams);
                FatGramLabel.Text = Convert.ToString(CaloriesFromFat);
            }
            catch
            {
                FatGramLabel.Text = "";
            }
        }

        private void CarbGramTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int CarbGrams = Int32.Parse(CarbGramTextbox.Text);
                int CaloriesFromCarbs = CarbCalories(CarbGrams);
                CarbGramLabel.Text = Convert.ToString(CaloriesFromCarbs);
            }
            catch
            {
                CarbGramLabel.Text = "";
            }
        }
        /************************************************************
         * This function turns grams of fat into Calories from Fat
         * @param amount of Fat in grams
         * @returns the amount of calories from fat
         ************************************************************/
        private int FatCalories(int FatGrams)
        {
            //Turn grams of fat to calories of fat by multipying by 9
            int CaloriesFromFat = FatGrams * 9;
            return CaloriesFromFat;
        }

        /***********************************************************
        * This function turns grams of carbs into Calories from Carbs
        * @param amount of Carbs in grams
        * @returns the amount of calories from carbs
        *********************************************************/
        private int CarbCalories(int CarbGrams)
        {
            //Turn grams of carbs to calories of carbs by multipying by 4
            int CaloriesFromCarbs = CarbGrams * 4;
            return CaloriesFromCarbs;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
