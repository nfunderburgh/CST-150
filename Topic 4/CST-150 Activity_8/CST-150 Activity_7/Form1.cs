using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FatGramTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int FatGrams = Int32.Parse(FatGramTextbox.Text);
                FatGrams = FatCalories(FatGrams);
                FatGramLabel.Text = Convert.ToString(FatGrams);
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
                CarbGrams = CarbCalories(CarbGrams);
                CarbGramLabel.Text = Convert.ToString(CarbGrams);
            }
            catch
            {
                CarbGramLabel.Text = "";
            }
        }
        /************************************************************
         * This function turns grams of fat into Calories from Fat
         * @param - int FatGrams - Amount of Fat in grams
         * 
         * 
         * 
         * 
         ************************************************************/
        private int FatCalories(int FatGrams)
        {
            FatGrams *= FatGrams * 9;
            return FatGrams;
        }

        /***********************************************************
        * This function turns grams of carbs into Calories from Carbs
        * @param - int CarbGrams - Amount of Carbs in grams
        * @returns int
        *********************************************************/
        private int CarbCalories(int CarbGrams)
        {
            CarbGrams *= CarbGrams * 4;
            return CarbGrams;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
