using System.Collections;


public class Inventory
{


    public static void Main(string[] args)
    {
        ArrayList itemNameList = new ArrayList();
        ArrayList itemCountList = new ArrayList();
        string keepGoing = "";
        bool quitProgram = true;
        while (quitProgram)
        {   

            Console.WriteLine("\nPlease pick a number");
            Console.WriteLine("1: Add product\n2: Remove product\n3: Restock products\n4: Print products\n5: Total items\n6: Quit");
            string userNumInput = Console.ReadLine();
            switch (userNumInput)
            {
                case "1":
                    addProduct(itemNameList, itemCountList);
                    break;
                case "2":
                    removeProduct(itemNameList, itemCountList);
                    break;
                case "3":
                    restockProduct(itemNameList, itemCountList);
                    break;
                case "4":
                    productList(itemNameList, itemCountList);
                    break;
                case "5":
                    productItemCount(itemNameList);
                    break;
                case "6":
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
     * @ param itemCountList is the count of items in inventory
     * @ return None
     * ************************************************************/
    public static void addProduct(ArrayList itemList, ArrayList itemCountList)
    {
        Console.Clear();
        Console.WriteLine("What product do you want to add:");
        string itemName = Console.ReadLine();
        itemList.Add(itemName);
        Console.WriteLine();
        Console.WriteLine("How many do you want to add:");
        string itemCount = Console.ReadLine();
        itemCountList.Add(itemCount);
    }

    /**************************************************************
    * Removes selected product and all its inventory
    * @ param itemList is the list of items
    * @ param itemCountList is the count of items in inventory
    * @ return None
    * ************************************************************/
    public static void removeProduct(ArrayList itemList, ArrayList itemCountList)
    {
        Console.Clear();
        Console.WriteLine("What product do you want to remove:");
        string itemName = Console.ReadLine();
        bool itemFound = false;
        for (int i = 0; i < itemList.Count; i++)
        {
            if (string.Equals(itemName, itemList[i]))
            {
                itemList.RemoveAt(i);
                itemCountList.RemoveAt(i);
                itemFound = true;
            }
        }
        if (!itemFound)
        {
            Console.WriteLine("\nItem could not be found\n");
        }
    }

    /**************************************************************
    * Restocks selected item
    * @ param itemList is the list of items
    * @ param itemCountList is the count of items in inventory
    * @ return None
    * ************************************************************/
    public static void restockProduct(ArrayList itemList, ArrayList itemCountList)
    {
        Console.Clear();
        Console.WriteLine("What product do you want to restock:");
        string itemName = Console.ReadLine();
        Console.WriteLine("\nHow many do you want to restock:");
        string itemCount = Console.ReadLine();
        bool itemFound = false;
        for (int i = 0; i < itemList.Count; i++)
        {
            if (string.Equals(itemName, itemList[i]))
            {
                int totalCount = Int32.Parse((string)itemCountList[i]) + int.Parse(itemCount);
                itemCountList[i] = totalCount.ToString();
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
    * @ param itemCountList is the count of items in inventory
    * @ return None
    * ************************************************************/
    public static void productList(ArrayList itemList, ArrayList itemCountList)
    {
        Console.Clear();
        Console.WriteLine("List of products: ");
        for (int i = 0; i < itemList.Count; i++)
        {
            Console.WriteLine("Product: " + itemList[i] + ", Amount: " + itemCountList[i]);
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