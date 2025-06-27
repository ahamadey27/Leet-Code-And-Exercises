using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{

    //Check if two Integer in Range -10 to 10
    public static class Exercise22
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 22");
            Console.WriteLine("Check if at least one integer is in Range -10 to 10");

            Console.Write("Enter first integer: ");
            int? userInOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int? userInTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((userInOne >= -10 && userInOne <= 10) || (userInTwo >= -10 && userInTwo <= 10));
            
        }
    }
}