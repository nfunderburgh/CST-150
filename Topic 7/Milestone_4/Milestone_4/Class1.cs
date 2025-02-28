﻿using System.Collections.Generic;
using System;

namespace Milestone_3

{
    public class Items
    {
        // Item constructor
        public Items(string productsName, double productPrice, int stock, int ProductNumber)
        {
            this.ProductName = productsName;
            this.ProductPrice = productPrice;
            this.ProductStock = stock;
            this.productNumber = ProductNumber;
        }

        // Getting product name
        private string productsName;
        public string ProductName
        {
            get { return productsName; }
            set { productsName = value; }
        }

        // getting product price
        private double productPrice;
        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }

        //getting amount in stock
        private int productStock;
        public int ProductStock
        {
            get { return productStock; }
            set { productStock = value; }
        }

        //getting product number
        private int ProductNumber;
        public int productNumber
        {
            get { return ProductNumber; }
            set { ProductNumber = value; }
        }

        //Changes product name
        public void changeproductName(string newName)
        {
            productsName = newName;
        }
        //Changes product price
        public void changeproductPrice(double newProductPrice)
        {
            productPrice = newProductPrice;
        }
        //Changes product stock
        public void changeStock(int newStock)
        {
            productStock = newStock;

        }
    }

    //checking for inventory
    public class Warehouse
    {
        public List<Items> Items = new List<Items>();

        //add an item to list
        public void addItems(Items item)
        {
            this.Items.Add(item);
        }

        //removes selected productNumber from the list
        public void removeItems(string id)
        {   int i = 0;
            int index = 0;
            foreach(Items item in this.Items)
            {
                if (item.productNumber.ToString() == id)
                {
                    index = i;
                }
                i++;
            }
            this.Items.RemoveAt(index);
        }

        //Prints the list onto the console for debugging.
        public void print()
        {
            foreach (Items item in Items)
            {
                Console.WriteLine("Product ID: " + item.productNumber + " Product Name: " + item.ProductName + " Product Price: " + item.ProductPrice + " Product Stock: " + item.ProductStock);
            }
            Console.WriteLine("---------------------");
        }

        // takes a ingteger that is the product number 
        // uses that number to check if the product is in the list
        // If it is we return the item 
        // If not we return null
        public Items findProduct(int productNumber)
        {
            Items item = null;
            foreach (Items items in this.Items)
            {
                if (items.productNumber == productNumber)
                {
                    item = items;
                }
            }
            return item;
        }

        // takes a string that is the product nname
        // uses that number to check if the product is in the list
        // If it is we return the item 
        // If not we return null
        public Items findProduct(string productName)
        {
            Items item = null;
            foreach (Items items in this.Items)
            {
                if (items.ProductName == productName)
                {
                    item = items;
                }
            }
            return item;
        }
    }
}
