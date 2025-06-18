using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace W3ResourceBasic.Exercises
{
    //Adds the first character of a string to both the front and back.
    public static class Exercise06
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 06");
            Console.WriteLine("Create a new string where the first character is added to the front and back");
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