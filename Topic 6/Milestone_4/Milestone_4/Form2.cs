using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Milestone_4
{
    public partial class Form2 : MaterialForm
    {
        LoginScreen loginscreen;
        public Form2(LoginScreen ls)
        {
            InitializeComponent();
            loginscreen = ls;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            itemIDTextbox.Text = "";
            itemNameTextbox.Text = "";
            itemPriceTextbox.Text = "";
            itemStockTextbox.Text = "";
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            double productNumber = double.Parse(itemIDTextbox.Text);
            string productsName = itemNameTextbox.Text;
            double productPrice = double.Parse(itemPriceTextbox.Text);
            int productStock = int.Parse(itemStockTextbox.Text);

            Items item = new Items(productsName, productPrice, productStock, productNumber);

            materialListView1.Items.Add(new ListViewItem(new string[] { item.productNumber.ToString(), item.ProductName, "$" + item.ProductPrice.ToString(), item.Stock.ToString() }));
        }
    }
}
