using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Hello World", "Bye World", "Useless World" };
            var newword = "";
           
            List<string> newList = new List<string>();

            foreach (string word in words)
            {
                // Revese the order of words in each array element
                string result = string.Join(" ", word.Split(' ').Reverse());

                // Test if array element contains double letters.
                // If true, replace double letters with '*' and add newWord element to newList.
                var count = 0;
                for (int i=1; i < result.Length; i++)
                {
                    
                    if (result[i] == result[i - 1])
                    {
                        count++;
                        newword = result.Insert(i, "*");
                        newword = newword.Remove(i + 1, 1);
                        newword = newword.Insert(i - 1, "*");
                        newword = newword.Remove(i, 1);

                        newList.Add(newword);

                    }
                    
                }

                // If element does not contain double letters, add reversed element to newList.
                if(count == 0)
                {
                    newList.Add(result);
                }

            }

            // Print newList to console.
            foreach(string item in newList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
