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
        Items item1;
        Items item2;
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
                wh.printArray();
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
                    item1 = new Items(productsName, productPrice, productStock, productNumber);
                    wh.addItems(item1);
                    addItemsToListView();
                    listView.BackColor = System.Drawing.Color.White;
                }
            }
            else
            {
                MessageBox.Show("That item ID is already in the list");
            }
            wh.printArray();
        }

        private void addItemsToListView()
        {
            lvi = new ListViewItem(item1.productNumber.ToString());
            lvi.SubItems.Add(item1.ProductName);
            lvi.SubItems.Add(item1.ProductPrice.ToString());
            lvi.SubItems.Add(item1.ProductStock.ToString());
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
                    item1.changeproductName(itemNameTextbox.Text);
                    item1.changeproductPrice(double.Parse(itemPriceTextbox.Text));
                    item1.changeStock(int.Parse(itemStockTextbox.Text));
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
            listView.Items[itemNum].SubItems[0].Text = item1.productNumber.ToString();
            listView.Items[itemNum].SubItems[1].Text = item1.ProductName;
            listView.Items[itemNum].SubItems[2].Text = item1.ProductPrice.ToString();
            listView.Items[itemNum].SubItems[3].Text = item1.ProductStock.ToString();
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

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem eachItem in listView.SelectedItems)
            {
                Console.WriteLine(eachItem.Text);
                item2 = wh.findProduct(double.Parse(eachItem.Text));
                itemIDTextbox.Text = item2.productNumber.ToString();
                itemNameTextbox.Text = item2.ProductName;
                itemPriceTextbox.Text = item2.ProductPrice.ToString();
                itemStockTextbox.Text = item2.ProductStock.ToString();

            }
        }
    }
}
