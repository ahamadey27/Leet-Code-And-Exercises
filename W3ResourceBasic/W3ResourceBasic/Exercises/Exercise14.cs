using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    //FizzBuzz Exercise
    public static class Exercise14
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 14");
            Console.WriteLine("FizzBuzz");

            Console.WriteLine("How many numbers do you want to fizz buzz?");
            int input = Convert.ToInt32(Console.ReadLine());


            bool fizz = false;
            bool buzz = false;

            for (int i = 1; i <= input; i++)
            {
                fizz = i % 3 == 0;
                buzz = i % 5 == 0;

                if (fizz && buzz)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (fizz)
                {
                    Console.WriteLine("Fizz");
                }

                else if (buzz)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}