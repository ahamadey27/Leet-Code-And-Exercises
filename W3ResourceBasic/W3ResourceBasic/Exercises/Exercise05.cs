using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise05
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 05");
            Console.WriteLine("Swap First and last characters of a string");
            Console.WriteLine("Please enter a single string");
            string? userInput = Console.ReadLine();
            Console.WriteLine(first_last(userInput));

           
        }

        public static string first_last (string ustr)
        {
            // Using the ternary operator to rearrange characters based on the length of the string
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1)
                : ustr; //returns input character for single-character string 
        }
    }
}