using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    //Check if number is palindrome
    public static class Exercise28
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 28");
            Console.WriteLine("Check if number is palindrome");

            Console.Write("Enter a number: ");
            int intOriginal = Convert.ToInt32(Console.ReadLine());

            string originalString = intOriginal.ToString();

            //convert to reverse string string
            string reversedString = new string(originalString.Reverse().ToArray());

            if (originalString == reversedString)
            {
                Console.WriteLine($"{originalString} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{originalString} is not a palindrome");
            }


        }
    }
}

//Time Complexity: O(n)
//Converting the integer to a string requires iterating through each digit, leading to O(n) complexity,
//where n is the number of digits in the integer. Reversing the string also takes O(n) time. Thus, 
//the total time complexity remains O(n).

//Space Complexity: O(n)
//The space needed to store the string representation of the integer (both original and reversed) is
//proportional to the number of digits, resulting in O(n) space complexity.