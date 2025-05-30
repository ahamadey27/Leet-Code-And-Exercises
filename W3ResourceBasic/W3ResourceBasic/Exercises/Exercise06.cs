using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise06
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 06");
            Console.WriteLine("Create a new string where the first character is added to the forst and back");
            string? str;

            Console.WriteLine("Input a string");
            str = Console.ReadLine();

            if (str.Length >=1)
            {
                var s = str.Substring(0, 1); //extracts first character of string
                Console.WriteLine(s + str + s);
            }
        }
    }
}