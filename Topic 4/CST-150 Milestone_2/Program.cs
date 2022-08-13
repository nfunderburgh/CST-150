
using System;
using System.Collections;

public class Inventory
{


    public static void Main(string[] args)
    {
        ArrayList itemNameList = new ArrayList();
        string keepGoing = "";
        bool quitProgram = true;
        while (quitProgram)
        {   

            Console.WriteLine("Please pick a number");
            Console.WriteLine("1: Add product\n2: Remove product\n3: Print products\n4: Total items\n5: Quit");
            string userNumInput = Console.ReadLine();
            switch (userNumInput)
            {
                case "1":
                    addProduct(itemNameList);
                    break;
                case "2":
                    removeProduct(itemNameList);
                    break;
                case "3":
                    productList(itemNameList);
                    break;
                case "4":
                    productItemCount(itemNameList);
                    break;
                case "5":
                    quitProgram = quit();
                    break;
                default:
                    Console.WriteLine("Unregcogizable number");
                    break;
            }
        }
    }


    /**************************************************************
     * Adds produc user types in into the arraylist of products
     * @ param itemList is the list of items
     * @ return None
     * ************************************************************/
    public static void addProduct(ArrayList itemList)
    {
        Console.Clear();
        Console.WriteLine("What product do you want to add:");
        string itemName = Console.ReadLine();
        itemList.Add(itemName);
        Console.WriteLine();
    }

    /**************************************************************
    * Adds product that user types in, into the arraylist of products
    * @ param itemList is the list of items
    * @ return None
    * ************************************************************/
    public static void removeProduct(ArrayList itemList)
    {
        Console.Clear();
        Console.WriteLine("What product do you want to remove:");
        string itemName = Console.ReadLine();
        bool itemFound = false;
        for (int i = 0; i < itemList.Count; i++)
        {
            if (itemName == itemList[i])
            {
                itemList.Remove(itemName);
                itemFound = true;
            }
        }
        if (!itemFound)
        {
            Console.WriteLine("\nItem could not be found\n");
        }
    }
    /**************************************************************
    * Prints the list all items int he arraylist
    * @ param itemList is the list of items
    * @ return None
    * ************************************************************/
    public static void productList(ArrayList itemList)
    {
        Console.Clear();
        Console.WriteLine("List of products: ");
        for (int i = 0; i < itemList.Count; i++)
        {
            Console.WriteLine(" " + itemList[i]);
        }
        Console.WriteLine();
    }
    /**************************************************************
    * prints the count of different items
    * @ param itemList is the list of items
    * @ return None
    * ************************************************************/
    public static void productItemCount(ArrayList itemList)
    {
        Console.Clear();
        Console.WriteLine("There are a total of " + itemList.Count + " different items");
        Console.WriteLine();
    }

    /**************************************************************
    * Quits the program
    * @ param None
    * @ return false
    * ************************************************************/
    public static bool quit()
    {
        Console.WriteLine("\nquiting program");
        return false;
    }
}