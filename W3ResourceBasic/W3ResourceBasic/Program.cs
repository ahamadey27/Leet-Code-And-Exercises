using W3ResourceBasic.Exercises;

Console.Write("Which exercise? \n");
var choice = Console.ReadLine();
switch (choice)
{
    case "mini01": MiniProj01.Run(); break; //Inventory system
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
    case "12": Exercise12.Run(); break; // Multiply the corresponding elements of two integer arra
    case "13": Exercise13.Run(); break; // Create a new string of four copies, taking last four characters from a given string
    case "14": Exercise14.Run(); break; // FizzBuzz!!!
    case "15": Exercise15.Run(); break; // Method to sum the elements in the array, knowing that some of the elements may be very large integers
    case "16": Exercise16.Run(); break; // Reverseing a string
    case "17": Exercise17.Run(); break; // Checks if password verifcation is correct with at least 2 special characters
    case "18": Exercise18.Run(); break; // Given an array of integers, write a method to total the odd numbers.
    case "19": Exercise19.Run(); break; //Given a string, remove any repeated letters
    case "20": Exercise20.Run(); break; //Check Multiple of 3 or 7
    case "21": Exercise21.Run(); break; //Check Numbers Less than 100 & Greater than 200
    case "22": Exercise22.Run(); break; //Check if an integer is in the range -10 to 10
    case "23": Exercise23.Run(); break; //Check if "HP" appears at second position in a string and returns the string without "HP"
    case "24": Exercise24.Run(); break; //Check String Starts with 'www'
    case "25": Exercise25.Run(); break; //Every other character in a string
    case "26": Exercise26.Run(); break; //Count a specified number in a given array of integers
    case "27": Exercise27.Run(); break; //Check if a string is a palindrome
    default: Console.WriteLine("Unknown"); break;
}