using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    public static class Exercise04
    {
        //Converts a Celsius temperature to Kelvin and Fahrenheit.
        public static void Run()
        {
            Console.WriteLine("Exercise 0");
            Console.WriteLine("Celsius to Kelvin and Fahrenheit");
            Console.WriteLine("Enter the amount in celsius");
            int celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Farenheir = {0}", celsius * 18 / 10 + 32);
            
        }
    }
}