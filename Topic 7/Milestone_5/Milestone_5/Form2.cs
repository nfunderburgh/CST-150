﻿using System;
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
        ListViewItem lvi1;
        ListViewItem lvi2;
        Warehouse wh;

        private ListViewColumnSorter lvwColumnSorter;
        public Form2(LoginScreen ls)
        {
            InitializeComponent();
            loginscreen = ls;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            listView.GridLines = true;
            listViewCopy.GridLines = true;

            lvwColumnSorter = new ListViewColumnSorter();
            wh = new Warehouse();

            this.listView.ListViewItemSorter = lvwColumnSorter;
        }

        // Used to exit the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Checks if for selected items in list view
        // any selected items are deleted from the list view and the item list
        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView.SelectedItems)
            {
                listView.Items.Remove(eachItem);
                wh.removeItems(eachItem.Text);
                wh.printArray();

            }
        }

        // Reset all textboxes to blank
        private void resetButton_Click(object sender, EventArgs e)
        {
            itemIDTextbox.Text = "";
            itemNameTextbox.Text = "";
            itemPriceTextbox.Text = "";
            itemStockTextbox.Text = "";
        }

        // Checks if item is already in the list, if it is we tell the user the item is already in the lsit
        // If its not we add the item into the list if everything is filled out
        // Otherwise we tell the user to please fill the form entirely
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
                    int productNumber = int.Parse(itemIDTextbox.Text);
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

        // Adds sub items into one item then we add that one item
        private void addItemsToListView()
        {
            lvi1 = new ListViewItem(item1.productNumber.ToString());
            lvi1.SubItems.Add(item1.ProductName);
            lvi1.SubItems.Add(item1.ProductPrice.ToString());
            lvi1.SubItems.Add(item1.ProductStock.ToString());
            lvi1.BackColor = Color.White;
            listView.Items.Add(lvi1);

        }

        // Tries to search for product 
        // If item2 isn't null then we found the item 
        // else we couldn't find the item in the list
        private void updateButton_Click(object sender, EventArgs e)
        {
            item2 = wh.findProduct(int.Parse(itemIDTextbox.Text));

            bool found = false;
            for (int i = 0; i < listView.Items.Count; i++)
            {
                if(listView.Items[i].SubItems[0].Text == itemIDTextbox.Text)
                {
                    item2.changeproductName(itemNameTextbox.Text);
                    item2.changeproductPrice(double.Parse(itemPriceTextbox.Text));
                    item2.changeStock(int.Parse(itemStockTextbox.Text));
                    found = true;
                    updateList(i,item2);
                }
            }
            if (!found)
            {
                MessageBox.Show("Could not find that item in the list");
            }
        }

        // Updates the sub items and prints list for debugging
        private void updateList(int itemNum, Items item2)
        {
  
            listView.Items[itemNum].SubItems[1].Text = item2.ProductName;
            listView.Items[itemNum].SubItems[2].Text = item2.ProductPrice.ToString();
            listView.Items[itemNum].SubItems[3].Text = item2.ProductStock.ToString();
            wh.printArray();
        }

        // Sorts the columns when clicked on in either ascending or descending order
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

        //Add selected items back into the textboxes for easy updating
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem eachItem in listView.SelectedItems)
            {
                item2 = wh.findProduct(int.Parse(eachItem.Text));
                itemIDTextbox.Text = item2.productNumber.ToString();
                itemNameTextbox.Text = item2.ProductName;
                itemPriceTextbox.Text = item2.ProductPrice.ToString();
                itemStockTextbox.Text = item2.ProductStock.ToString();

            }
        }

        // When the user searchs an item
        // Add the items to a different form and it will display a different form and hide the original
        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextbox.Text == "")
            {
                listView.Show();
                listViewCopy.Hide();
                listViewCopy.Items.Clear();
            }
            else
            {
                try
                {
                    item2 = wh.findProduct(int.Parse(searchTextbox.Text));
                }
                catch
                {
                    item2 = wh.findProduct(searchTextbox.Text);
                }
                if(item2 != null)
                {
                    lvi2 = new ListViewItem(item2.productNumber.ToString());
                    lvi2.SubItems.Add(item2.ProductName);
                    lvi2.SubItems.Add(item2.ProductPrice.ToString());
                    lvi2.SubItems.Add(item2.ProductStock.ToString());
                    lvi2.BackColor = Color.White;
                    listViewCopy.Items.Add(lvi2);
                    listViewCopy.Show();
                    listView.Hide();
                    listViewCopy.BackColor = System.Drawing.Color.White;
                }
            }
        }
    }
}
