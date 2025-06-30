using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise24
    {
        //Check String Starts with 'www'
        public static void Run()
        {
            Console.WriteLine("Exercise 24");
            Console.WriteLine("Check String Starts with 'www");

            Console.Write("Input a string: ");
            string str = Console.ReadLine();
        }

        public static bool test(string str) //method that a string paramater 'str' and returns a boolean value
        {
            var ctr = 0; //initiliazes counter to count occurences of 'w'

            //Iterates though the character of the string using a for loop
            for (var i = 0; i < str.Length; i++)
            {
                //Checks if character it 'w', if so increments counter 'ctr'
                if (str[i].Equals('w'))
                    ctr++;

                //Checks if substring of length 2 starting at index 'i' contains "ww"
                //And if counter is greater than 2
                if (str.Substring(i, 2).Equals("ww") && ctr > 2)
                    return true;
            }

            return false;
        }
    }
}