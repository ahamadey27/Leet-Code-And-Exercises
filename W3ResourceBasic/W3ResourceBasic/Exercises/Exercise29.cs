using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise29
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 29");
            Console.WriteLine("Reverse a String Without Using Built-in Functions");
            Console.Write("Please enter a sting");
            string userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Enter a valid input");
            }

            char[] reversed = new char[userInput.Length];

            for (int i = 0; i <= userInput.Length; i++)
            {
                reversed[i] = userInput[userInput.Length - 1 - i];
            }

            Console.WriteLine($"{userInput} reversed is {reversed}");

            
                
        }
    }
}