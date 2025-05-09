using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Test
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 1: Hello, world!");
            Console.WriteLine("Please enter a letter:");
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine();  // Add a new line after key input
            Console.WriteLine($"Here is your letter: {letter}");
        }
    }
}
