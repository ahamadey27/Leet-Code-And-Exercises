using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise08
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 08");
            Console.WriteLine("Convert string to lower case");
            Console.WriteLine("Please enter a string");
            string? inputLine;
            inputLine = Console.ReadLine().ToLower();
            Console.WriteLine("{0} is your backwards word", inputLine);
              
        }
    }
}