using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise10
    {
        // Computes the sum of the digits of an integer.
        public static void Run()
        {
            Console.WriteLine("Exercise 10");
            Console.WriteLine("Compute the sum of an integer's digits");
            Console.WriteLine("Enter an integer");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (n != 0)
            {
                sum += n % 10; //Adding the last digit 'n' to the sum
                n /= 10; //Removes the last digit from 'n'

            }

            Console.WriteLine($"The sum of the inegers are {sum}");
        }
    }
}