﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourceBasic.Exercises
{
    //Given an array of integers, write a method to sum the elements in the array.
    public static class Exercise15
    {
        public static void Run()
        {
            Console.WriteLine("Exercise 15");
            Console.WriteLine("Given an array of integers, write a method to sum the elements in the array.");

            Console.WriteLine("Enter 10 integers");

            int[] arrayMain = new int[10];

            for (int i = 0;i < arrayMain.Length; i++)
            {
                Console.WriteLine("Enter integer " + (i + 1));
                arrayMain[i] = int.Parse(Console.ReadLine());
            }

            int arraySum = arrayMain.Sum();

            //for (int j = 0; j < arrayMain.Length; j++)
            //{
            //    arraySum += arrayMain[j];
            //}

            Console.WriteLine("Sum of elements in the array is " + arraySum);


        }
    }
}