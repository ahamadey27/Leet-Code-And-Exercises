using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise02
    {
        // Exercise 02: Prints the multiplication table for a given number up to 12.
        public static void Run()
        {
            Console.WriteLine("Exercise 02");
            Console.WriteLine("Using a for loop to print the multiplication table of input n to 12");
     
            Console.WriteLine("Enter a number and you'll recieve this number multiplied from 1 to 12");

            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
                
           
        }
    }
}
