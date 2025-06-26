using W3ResourceBasic.Exercises;

Console.Write("Which exercise? \n");
var choice = Console.ReadLine();
switch (choice)
{
    case "1": Exercise01.Run(); break; // Swaps two numbers entered by the user.
    case "2": Exercise02.Run(); break; // Prints the multiplication table for a given number up to 12.
    case "3": Exercise03.Run(); break; // Calculates the average of four numbers entered by the user.
    case "4": Exercise04.Run(); break; // Converts a Celsius temperature to Kelvin and Fahrenheit.
    case "5": Exercise05.Run(); break; // Swaps the first and last characters of a string.
    case "6": Exercise06.Run(); break; // Adds the first character of a string to both the front and back.
    case "7": Exercise07.Run(); break; // Checks if one integer is positive and the other is negative.
    case "8": Exercise08.Run(); break; // Converts a user-input string to lower case.
    case "9": Exercise09.Run(); break; // Prints all odd numbers from 1 to 99.
    case "10": Exercise10.Run(); break; // Computes the sum of the digits of an integer.
    case "11": Exercise11.Run(); break; // Reverses the order of words in a sentence.
    case "12": Exercise12.Run(); break; //Multiply the corresponding elements of two integer arra
    case "13": Exercise13.Run(); break; //Create a new string of four copies, taking last four characters from a given string
    case "14": Exercise14.Run(); break; //FizzBuzz!!!
    case "15": Exercise15.Run(); break; //Method to sum the elements in the array, knowing that some of the elements may be very large integers
    case "16": Exercise16.Run(); break; //Reverseing a string
    default: Console.WriteLine("Unknown"); break;
}