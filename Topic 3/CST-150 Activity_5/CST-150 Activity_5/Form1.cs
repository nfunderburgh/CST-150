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

        private async void Read_File_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string[] lines = File.ReadAllLines(filename);
            lines = lines.Select(v => v.ToLower()).ToArray();

            Array.Sort(lines);

            string longWord = longestWord(lines);
            string vowelWord = vowelCounter(lines);

            string[] output = { "First Word Alphabetically: " + lines[0], "Last Word Alphabetically: " + lines[lines.Count() - 1],
            "Longest Word: " + longWord, "Word With Most Vowels: " + vowelWord };

            File.WriteAllLines("Result.txt", output);
            richTextBox1.Text = string.Join("\n", output);


        }

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

        private string vowelCounter(string[] lines)
        {
            int currVowelCount = 0;
            int mostVowelCount = 0;
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
                if (currVowelCount > mostVowelCount)
                {
                    mostVowelCount = currVowelCount;
                    wordWithMostVowels = lines[i];
                    currVowelCount = 0;
                }
            }
            return wordWithMostVowels;
        }

    }
}
