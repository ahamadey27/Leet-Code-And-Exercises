using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    //Check Numbers Less than 100 & Greater than 200
    public static class Exercise21
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 21");
            Console.WriteLine("Check Numbers Less than 100 & Greater than 200");
            Console.Write("Enter a number to check if number meets above conditions: ");
            int? userInput = Convert.ToInt32(Console.ReadLine());
            
            if (userInput < 100)
            {
                Console.WriteLine($"{userInput} is less than 100");
            }
            else if (userInput > 200)
            {
                Console.WriteLine($"{userInput} is greater than 200");
            }
            else
            {
                Console.WriteLine($"{userInput} is between 100 and 200");
            }
        }
    }
}