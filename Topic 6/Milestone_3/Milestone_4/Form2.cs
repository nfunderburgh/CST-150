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

namespace Milestone_3
{
    public partial class Form2 : MaterialForm
    {
        LoginScreen loginscreen;
        Items item;
        ListViewItem lvi;
        Warehouse wh;

        private ListViewColumnSorter lvwColumnSorter;
        public Form2(LoginScreen ls)
        {
            InitializeComponent();
            loginscreen = ls;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            listView.GridLines = true;

            lvwColumnSorter = new ListViewColumnSorter();
            wh = new Warehouse();

            this.listView.ListViewItemSorter = lvwColumnSorter;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView.SelectedItems)
            {
                listView.Items.Remove(eachItem);
                wh.removeItems(eachItem.Text);

            }
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
            bool found = false;
            for (int i = 0; i < listView.Items.Count; i++)
            {
                if (listView.Items[i].SubItems[0].Text == itemIDTextbox.Text)
                {
                    found = true;
                }
            }
            if (!found)
            {
                if (itemIDTextbox.Text == "" || itemNameTextbox.Text == "" || itemPriceTextbox.Text == "" || itemStockTextbox.Text == "")
                {
                    MessageBox.Show("Please Fill out form to add/update an item");
                }
                else
                {
                    double productNumber = double.Parse(itemIDTextbox.Text);
                    string productsName = itemNameTextbox.Text;
                    double productPrice = double.Parse(itemPriceTextbox.Text);
                    int productStock = int.Parse(itemStockTextbox.Text);
                    item = new Items(productsName, productPrice, productStock, productNumber);
                    wh.addItems(item);
                    addItemsToListView();
                    listView.BackColor = System.Drawing.Color.White;
                }
            }
            else
            {
                MessageBox.Show("That item ID is already in the list");
            }
        }

        private void addItemsToListView()
        {
            lvi = new ListViewItem(item.productNumber.ToString());
            lvi.SubItems.Add(item.ProductName);
            lvi.SubItems.Add(item.ProductPrice.ToString());
            lvi.SubItems.Add(item.ProductStock.ToString());
            lvi.BackColor = Color.White;
            listView.Items.Add(lvi);

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            for (int i = 0; i < listView.Items.Count; i++)
            {
                if(listView.Items[i].SubItems[0].Text == itemIDTextbox.Text)
                {
                    item.changeproductName(itemNameTextbox.Text);
                    item.changeproductPrice(double.Parse(itemPriceTextbox.Text));
                    item.changeStock(int.Parse(itemStockTextbox.Text));
                    found = true;
                    updateList(i);
                }
            }
            if (!found)
            {
                MessageBox.Show("Could not find that item in the list");
            }
        }

        private void updateList(int itemNum)
        {
            listView.Items[itemNum].SubItems[0].Text = item.productNumber.ToString();
            listView.Items[itemNum].SubItems[1].Text = item.ProductName;
            listView.Items[itemNum].SubItems[2].Text = item.ProductPrice.ToString();
            listView.Items[itemNum].SubItems[3].Text = item.ProductStock.ToString();
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listView.Sort();
        }
    }
}
