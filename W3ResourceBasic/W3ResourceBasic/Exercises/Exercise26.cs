using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    //Count a specified number in a given array
    public static class Exercise26
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 26");
            Console.WriteLine("Count a specified number in a given array");

            Console.Write("Input an integer");
            int numSearch = Convert.ToInt32(Console.ReadLine());

            //Define array of nums that will be used to search for user input
            int[] numArray = { 1, 2, 5, 7, 8, 8, 9, 8, 3, 4, 7, 5, 6, 2, 3, 7, 7, 4, 1, 2, 3, 5, 6, 7, 8, 9 };

            Console.Write($"Number of {numSearch}s present in this array is ");

            //For each element n in numArray, checks if n is equal to numSearch 
            //Result is total number of numSearches appears in numArray
            Console.Write(numArray.Count(n => n == numSearch));
        }
    }
}