using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CST_150_Activity_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string[] lines = File.ReadAllLines(filename);
            //turns all strings into lowercase strings
            lines = lines.Select(v => v.ToLower()).ToArray();
            //Sorts lines by alphabetical order
            Array.Sort(lines);

            string longWord = longestWord(lines);
            string wordWithMostVowels = vowelCounter(lines);

            string[] output = { "First Word Alphabetically: " + lines[0], "Last Word Alphabetically: " + lines[lines.Count() - 1],
            "Longest Word: " + longWord, "Word With Most Vowels: " + wordWithMostVowels };

            File.WriteAllLines("../../../Output.txt", output);
            mainTextbox.Text = string.Join("\n", output);


        }

        /*****************************************************************
         * this function will find the longest word in an array of strings
         * @param - array of strings to search for the longest word
         * @return - string with most characters
         * **************************************************************/
        private string longestWord(string[] lines)
        {
            string longestWord = "";
            for (int i = 0; i < lines.Count(); i ++)
            {
                if(lines[i].Length > longestWord.Length) {
                    longestWord = lines[i];
                }
            }
            return longestWord;
        }

        /*****************************************************************
        * this function will find the longest word in an array of with the most vowels.
        * @param - array of strings to search for word with most vowels
        * @return - string with the most vowels meaning characters a,e,i,o,u 
        * **************************************************************/
        private string vowelCounter(string[] lines)
        {
            int currVowelCount = 0;
            int highestVowelCount = 0;
            string wordWithMostVowels = "";
            for (int i = 0; i < lines.Count(); i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] == 'a' || lines[i][j] == 'e' || lines[i][j] == 'i' || lines[i][j] == 'o' || lines[i][j] == 'u')
                    {
                        currVowelCount++;
                    }
                }
                if (currVowelCount > highestVowelCount)
                {
                    highestVowelCount = currVowelCount;
                    wordWithMostVowels = lines[i];
                    currVowelCount = 0;
                }
            }
            return wordWithMostVowels;
        }
    }
}
