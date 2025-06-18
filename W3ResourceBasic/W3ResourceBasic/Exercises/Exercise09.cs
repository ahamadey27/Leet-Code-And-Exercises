using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise09
    {
        //Prints all odd numbers from 1 to 99.
        public static void Run()
        {
            Console.WriteLine("Exercise 09");
            Console.WriteLine("Program to print odd numbers from 1 to 99. Prints one number per line");
            
            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}