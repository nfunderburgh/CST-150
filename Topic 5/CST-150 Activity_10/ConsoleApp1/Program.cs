// Corrected by Noah Funderburgh

using System;
using System.Collections.Generic;
using System.Linq;using System.Text;
using System.Threading.Tasks;

namespace Activity_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }
            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));
            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
        }
    }

    class Set
    {
        private List<int> elements;
        public Set()
        {
            elements = new List<int>();
        }
        public bool addElement(int val)
        {
            if (containsElement(val)) 
                return false; 
            else 
            { 
                elements.Add(val); 
                return true; 
            }
        }
        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                // Not needed else return
                //else
                    //return false;
            }
            return false;
        }
        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }
        public void clearSet()
        {
            elements.Clear();
        }
        public Set union(Set rhs)
        {
            // Creating a new set to keep orignal set values
            Set newSet = new Set();
            // Adds rhs into set
            for (int i = 0; i < rhs.elements.Count; i++) 
            { 
                newSet.addElement(rhs.elements[i]); 
            }
            // Then adds elements from this. if needed into the set
            for (int j = 0; j < this.elements.Count; j++)
            {
                newSet.addElement(this.elements[j]);
            }
            return newSet;
        }
    }
}
