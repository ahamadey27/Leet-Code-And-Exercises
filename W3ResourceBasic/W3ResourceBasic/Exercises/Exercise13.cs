using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    //Create a new string of four copies, taking last four characters from a given string
    public static class Exercise13
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 13");
            Console.WriteLine("Create a new string of four copies, taking last four characters from a given string");

            string str;
            int l = 0;

            Console.WriteLine("Input a string: ");
            str = Console.ReadLine();

            //check if length of string is greater than 4
            if (str.Length > 4)
            {
                // If the length is less than 4, concatenate the input string thrice

                // If the length is greater than or equal to 4,
                // concatenate the last 4 characters of the input string four times

                Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));

            }
            



        }
    }
}