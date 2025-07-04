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
                Console.WriteLine("Enter a valid input: ");
            }

            char[] reversed = new char[userInput.Length];

            // Loop through each character in the input string from start to end.
            // For each position i, assign the character from the end of the input string
            // (userInput.Length - 1 - i) to the current position in the reversed array.
            // This effectively reverses the string by copying characters from the end to the start.
            for (int i = 0; i < userInput.Length; i++)
            {
                reversed[i] = userInput[userInput.Length - 1 - i]; //so first calculation takes us to the last index of the char array
            }

            // Use new string(reversed) to convert the char array to a string for output
            Console.WriteLine($"{userInput} reversed is {new string(reversed)}");


           
          

            
                
        }
    }
}