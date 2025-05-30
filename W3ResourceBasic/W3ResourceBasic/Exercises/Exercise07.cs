using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise07
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 07");
            Console.WriteLine("Check a pair of integers and return true if one is negative and one is positive");
            int intOne, intTwo;
            Console.WriteLine("Enter an integer");
            intOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another integer");
            intTwo = Convert.ToInt32(Console.ReadLine());

            if ((intOne > 0 && intTwo < 0) || (intOne < 0 && intTwo > 0))
            {
                Console.WriteLine("One integer is positive and the other is negative ");
            }
            else
            {
                Console.WriteLine("Try again.");
            }
        }
    }
}