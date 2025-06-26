using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    //Given a string, remove any repeated letters.
    public static class Exercise19
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 19");
            Console.WriteLine("Given a string, remove any repeated letters.");

            Console.WriteLine("Please enter a string with repeated letters");
            string? userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("No input provided");
                return;
            }

            //HashSet<char> only stores unique values, so it can't hold two of the same characters
            HashSet<char> hashList = new HashSet<char>();
            string? result = "";

            //If c is not already in the set, it returns true and adds c to the result string.
            //If c is already in the set, it returns false and does not add c to the result string.
            foreach (char c in userInput)
            {
                if (hashList.Add(c)) //tries to add character to set
                {
                    result += c;
                }
                
            }

            Console.WriteLine(result);

        }
    }
}