using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise11
    {
        //Reverse the order of words in a sentence
        public static void Run()
        {
            Console.WriteLine("Exercise 11");
            Console.WriteLine("Reverse the order of words in a sentence");

            Console.WriteLine("Enter a sentance.");
            string? line = Console.ReadLine();

            string result = "";
            List<string> wordList = new List<string>();// Creating a list to store reversed strings

            string[] words = line.Split(new[] { " " }, StringSplitOptions.None); // Splitting the string into individual words

            // Loop to reverse the words and create a new string
            for (int i = words.Length - 1; i > 0; i--)
            {
                result += words[i] + " ";// Building the reversed string by adding words in reverse order
            }

            wordList.Add(result);  // Adding the reversed string to the list

            foreach (String s in wordList)
            {
                Console.WriteLine("\nReverse String: " + s);
            }

        }
    }
}