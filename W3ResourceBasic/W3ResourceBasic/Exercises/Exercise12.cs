using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    //Multiply the corresponding elements of two integer arrays and product sum
    public static class Exercise12
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 12");
            Console.WriteLine("Multiply the corresponding elements of two integer arrays");
            Console.WriteLine("Enter four elements for first array");

            int[] arrayOne = new int[4];
            int[] arrayTwo = new int[4];

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

            int sum = 0;

            //Loop through arrays to multiply multiplication of corresponding elements of both arrays
            for (int i= 0; i < arrayOne.Length; i++)
            {
                int product = arrayOne[i] * arrayTwo[i];
                Console.WriteLine($"Element {i} result is {product}");
                Console.WriteLine($"product sume of element {i} is " + (sum += product));

                
            }


        }
    }
}