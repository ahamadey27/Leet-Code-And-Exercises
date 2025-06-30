using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    //Check a palindrome string
    public static class Exercise27
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 27");
            Console.WriteLine("Check a palindrome string");

            Console.Write("Enter a word and see if it's a palindrome");
            string userInput = Console.ReadLine();

            char[] charArray = userInput.ToCharArray();

            //Reverse Array
            Array.Reverse(charArray);

            bool isPalindrome = new string(charArray).Equals(userInput);

            if (isPalindrome == true)
            {
                Console.WriteLine($"{userInput} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{userInput} is not a palindrome");
            }
        }
    }
}