using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise16
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 16");
            Console.WriteLine("Print a string in reverse");

            Console.Write("Please enter a single string:");
            string message = Console.ReadLine();

            Console.WriteLine($"{message} is {message.Length} characters long and reversed is: ");
            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
                
            }
        }
    }
}