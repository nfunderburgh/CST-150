using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines(@"..\..\..\TextFile1.txt");
        int Count = 0;
 
        foreach( string line in lines)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if (Char.ToLower(line[i]) == 'e' || Char.ToLower(line[i]) == 't')
                {
                    // If we reach here and an exception occurs this means we have reached the end of the string
                    // Therefore we can conclude since the last letter was E or T and its the end of the string the word 
                    // must in a E or T
                    try
                    {
                        if (Char.ToLower(line[i +1]) == ' ' || Char.ToLower(line[i + 1]) == '.')
                        {
                            Count++;
                        }
                    }
                    catch
                    {
                        Count++;
                    }
                }   
              
            }
        }
        Console.Write("There are " + Count + " words that end in T or E");
    }
}
