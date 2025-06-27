using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise23
    {
        //Check if "HP" appears at second position in a string and returns the string without "HP"
        public static void Run()
        {
            string? phpString;
            Console.WriteLine("Exercise 23");
            Console.WriteLine("Check if \"HP\" appears at second position in a string and returns the string without \"HP\"");
            Console.Write("Enter PHP Tutorial.");

            //loops until user enter correct string
            do
            {
                phpString = Console.ReadLine();

                if (phpString != "PHP Tutorial")
                {
                    Console.WriteLine("Please try again");
                }
            } while (phpString != "PHP Tutorial");

            // Check if the substring from index 1 of length 2 in 'str' equals "HP"
            // If true, remove the substring "HP" starting from index 1; otherwise, keep the original string 'str'
            Console.WriteLine((phpString.Substring(1, 2).Equals("HP") ? phpString.Remove(1, 2) : phpString));
        }
    }
}