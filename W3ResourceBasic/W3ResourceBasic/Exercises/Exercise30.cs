using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise30
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 30");
            Console.WriteLine("Determine if a Number is a Palindrome");

            Console.Write("Enter number: ");

            string? numStr = Console.ReadLine();

            string reversedString = "";

            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                reversedString += numStr[i];

            }

            if (reversedString == numStr)
            {
                Console.WriteLine($"{numStr} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{numStr} is not palindrome");

            }

        }
    }
}