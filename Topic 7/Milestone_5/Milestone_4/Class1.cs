using System.Collections.Generic;
using System;

namespace Milestone_3

{
    public class Items
    {
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
        private double ProductNumber;
        public double productNumber
        {
            get { return ProductNumber; }
            set { ProductNumber = value; }
        }

        public Items(string productsName, double productPrice, int stock, double ProductNumber)
        {
            this.ProductName = productsName;
            this.ProductPrice = productPrice;
            this.ProductStock = stock;
            this.productNumber = ProductNumber;
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

        //add item to list
        public void addItems(Items item)
        {
            this.Items.Add(item);
        }

        //removes items 
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

        public void printArray()
        {
            foreach (Items item in Items)
            {
                Console.WriteLine("Product ID: " + item.productNumber + " Product Name: " + item.ProductName + " Product Price: " + item.ProductPrice + " Product Stock: " + item.ProductStock);
            }
        }

        public Items findProduct(double productNumber)
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
    }
}
