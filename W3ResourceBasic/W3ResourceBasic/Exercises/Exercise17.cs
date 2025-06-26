using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    /* Ask user to enter password and store
     * ask user again to enter password and store
     * check if password matches, do not match or empty
     */
    public static class Exercise17
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 17");
            Console.WriteLine("Password Checker");
            Console.Write("Please enter your password and must contain at least 2 special characters and at least 6 characters long: ");
            string? password = Console.ReadLine(); // Allow null values by using nullable type

            // Define array of special characters
            char[] specials = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~".ToCharArray(); // Copies characters to char array

            // Check if password is not null/empty, has at least 2 special characters, and is at least 6 characters long
            if (!string.IsNullOrEmpty(password) && password.Count(c => specials.Contains(c)) >= 2 && password.Length >= 6)
            {
                // If valid, prompt user to retype password for verification
                Console.Write("Please retype password");
            }
            else
            {
                // If invalid, show error message
                Console.WriteLine("Password must contain at least 2 special characters. Please try again");
            }

            // Read the retyped password from user
            string? passwordVarify = Console.ReadLine();

            // Use ternary operator to check if both passwords match
            string verifcation = (password == passwordVarify) ? "Password matches" : "Password does not match"; // Ternary Expression
            Console.WriteLine(verifcation);
        }
    }
}