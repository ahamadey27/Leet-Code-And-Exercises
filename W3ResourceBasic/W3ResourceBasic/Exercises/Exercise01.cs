using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise01
    {
        // Exercise 01: Swaps two numbers entered by the user.
        public static void Run()
        {
            Console.WriteLine("Exercise 01");
            Console.WriteLine("Write a C# Sharp program to swap two numbers.");

            int num1, num2, temp;

            Console.WriteLine("Enter first nmumber: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter secoond nmumber: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"You entered {num1} and {num2}. Will swap these numbers for ya!");

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"Here are your numbers swapped: {num1} and {num2}");




        }
    }
}
