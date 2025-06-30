using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise25
    {
        //Every Other Character in String
        public static void Run()
        {
            Console.WriteLine("Exercise 25");
            Console.WriteLine("Every Other Character in String");

            Console.Write("Inout a string: ");
            string userInput = Console.ReadLine();

            //Initiazlize empty string variable that to store characters an even indices
            var result = string.Empty;

            //Iterate though characters of the input string
            for (var i = 0; i < userInput.Length; i++)
            {
                //if index is even, add the character index i to result variable
                if (i % 2 == 0)
                {
                    result += userInput[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}