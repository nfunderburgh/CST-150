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
                    // If we reach here and an exception occurs then we are at the end of the string meaning the last
                    // word has a E or T at the end of word
                    try
                    {
                        if (Char.ToLower(line[i +1]) == ' ')
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
