using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    //Check Multiple of 3 or 7
    public static class Exercise20
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 20");
            Console.WriteLine("Check Multiple of 3 or 7");
            Console.Write("Enter an integer: ");
            int? userInput = Convert.ToInt32(Console.ReadLine());
            
            if (userInput % 3 == 0 || userInput % 7 == 0)
            {
                Console.WriteLine($"{userInput} is divisible by 3 or 7");
            }
            else
            {
                Console.WriteLine($"{userInput} is not divisible by 3 or 7");
            }
        }
    }
}