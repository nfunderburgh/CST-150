using Milestone_3;
using System;
public class main
{
    public static void Main(string[] args)
    {
        Items item = new Items("Apple", 1.50, 10, 1);
        Items item2 = new Items("Orange", 2.50, 10, 2);
        item.addItems(item);
        item.addItems(item2);
        item.addItems(new Items("Grape", 1, 5, 2));
        item.addItems(new Items("Cherry", 5, 20, 4));
        item.addItems(new Items("Pear", 3, 10, 5));
        item.addItems(new Items("Banana", 4, 110, 6));
        item.printArray();
        Console.WriteLine("Restocking apples");
        item.restockItem(item,20);
        Console.WriteLine("Product ID: " + item.productNumber + " Product Name: " + item.ProductName + " Product Price: " + item.ProductPrice + " Product Stock: " + item.ProductStock);
        Console.WriteLine("Removing item ");
        item.removeItems(3);
        item.printArray();
        Console.WriteLine("Removing item");
        item.removeItems(2);
        item.printArray();
        Console.WriteLine("Changing apples to avocados");
        item.changeproductName("Avocados");
        item.printArray();
        item2 = item.findProduct("Banana", 6);
        item.printArray();
        Console.WriteLine("Searching for Banana");
        Console.WriteLine("Product ID: " + item2.productNumber + " Product Name: " + item2.ProductName + " Product Price: " + item2.ProductPrice + " Product Stock: " + item2.ProductStock);
        Console.WriteLine("Restocking Banana");
        item2.restockItem(item2,200);
        Console.WriteLine("Product ID: " + item2.productNumber + " Product Name: " + item2.ProductName + " Product Price: " + item2.ProductPrice + " Product Stock: " + item2.ProductStock);
        Console.WriteLine("Removing item");
        item.removeItems(1);
        item.printArray();
        Console.WriteLine("Adding item");
        item.addItems(new Items("Pear", 3, 10, 5));
        item.printArray();
        Console.WriteLine("searching for pear");
        item2 = item.findProduct("Pear", 5);
        Console.WriteLine("Product ID: " + item2.productNumber + " Product Name: " + item2.ProductName + " Product Price: " + item2.ProductPrice + " Product Stock: " + item2.ProductStock);


    }
}