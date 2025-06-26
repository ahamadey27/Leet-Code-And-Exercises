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
            string? password;
            char[] specials = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~".ToCharArray(); // Copies characters to char array

            Console.WriteLine("Exercise 17");
            Console.WriteLine("Password Checker");
            Console.Write("Please enter your password and must contain at least 2 special characters and at least 6 characters long: ");

            do
            {
                password = Console.ReadLine();

                //use && to make sure all conditions have to be met
                bool isValid = !string.IsNullOrEmpty(password) && password.Count(c => specials.Contains(c)) >= 2 && password.Length >= 6;

                if (!isValid)
                {
                    Console.WriteLine("Try again: ");
                }
                else
                {
                    Console.WriteLine("Retype your password :");
                }

            } while (string.IsNullOrEmpty(password) || password.Count(c => specials.Contains(c)) < 2 ||
                    password.Length < 6); //Use || so if one condition is not meant then loop continues
                
            // Read the retyped password from user
            string? passwordVarify = Console.ReadLine();

            // Use ternary operator to check if both passwords match
            string verifcation = (password == passwordVarify) ? "Password matches" : "Password does not match"; // Ternary Expression
            Console.WriteLine(verifcation);
        }
    }
}