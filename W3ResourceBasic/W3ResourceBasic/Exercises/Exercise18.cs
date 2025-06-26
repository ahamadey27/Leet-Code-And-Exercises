using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise18
    {
        //Given an array of integers, write a method to total the odd numbers.
        public static void Run()
        {
            Console.WriteLine("Exercise 18");
            Console.WriteLine("Given an array of integers, write a method to total the odd numbers.");
            int[] numArry = { 34, 46, 35, 7, 35, 2, 64, 84, 57, 76 };
            int sum = 0;

            for (int i = 0; i < numArry.Length; i++)
            {
         
                if (numArry[i] % 2 != 0 )
                {
                    sum += numArry[i];
                }
            }

            Console.WriteLine($"Total of odd elemnts in arary is {sum}");
        }
    }
}