using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise03
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 3");
            Console.WriteLine("Average of Four Numbers from user input into an array");
            List<int> userInts = new List<int>(); 

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"Please enter a digit for number {i} of 4");
                string userValue = Console.ReadLine();
                int userInt;
                if (int.TryParse(userValue, out userInt))
                {
                    userInts.Add(userInt);
                }

            }

            double average = userInts.Average();
            Console.WriteLine($"The average of the numbers you entered is {average}");
       
        }
    }
}
