using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    //Multiply the corresponding elements of two integer arrays
    public static class Exercise12
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 12");
            Console.WriteLine("Multiply the corresponding elements of two integer arrays");
            Console.WriteLine("Enter four elements for first array");

            int[] arrayOne = new int[3];
            int[] arrayTwo = new int[3];

            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.WriteLine($"Enter number {i + 1}");
                arrayOne[i] = int.Parse(Console.ReadLine()); // Fix: Convert string input to integer
            }

            Console.WriteLine("Enter four elements for second array");

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                Console.WriteLine($"Enter number {i + 1}");
                arrayTwo[i] = int.Parse(Console.ReadLine()); // Fix: Convert string input to integer
            }


        }
    }
}