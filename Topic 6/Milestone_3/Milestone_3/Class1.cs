using System.Collections.Generic;
using System;
using System.Collections;

namespace Milestone_3
{
    public class Items
    {
        ArrayList arrayList = new ArrayList();

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
        public void addItems(Items item)
        {
            bool found = false;
            foreach (Items items in this.arrayList)
            {
                if (item.productNumber == items.productNumber)
                {
                    Console.WriteLine("Item Already exists");
                    found = true;
                }

            }
            if (!found)
            {
                arrayList.Add(item);
            }
        }

        public void removeItems(int index)
        {
            arrayList.RemoveAt(index);
        }
        public void restockItem(Items items, int stock)
        {
            items.changeStock(stock + productStock);
        }

        public Items findProduct(string productName, double productNumber)
        {
            Items item = null;
            foreach (Items items in this.arrayList)
            {
                if (items.ProductName == productName && items.productNumber == productNumber)
                {
                    item = items;
                }
               
            }
            return item;
        }

        public void printArray()
        {
            foreach(Items item in arrayList)
            {
                Console.WriteLine("Product ID: " + item.productNumber + " Product Name: " + item.ProductName + " Product Price: " + item.ProductPrice + " Product Stock: " + item.ProductStock);
            }
          
        }
    }
}
