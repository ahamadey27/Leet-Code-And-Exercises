using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise30
    {
        public static bool Run()
        {
            Console.WriteLine("Exercise 30");
            Console.WriteLine("Determine if a Number is a Palindrome");

            Console.Write("Enter number: ");

            string? numStr = Console.ReadLine();

            int len = numStr.Length;

            for (int i = 0; i < len / 2; i++)
            {
                if (numStr[i] != numStr[len - 1 - i])
                    return false;
            }

            return true;

        }


    }
}