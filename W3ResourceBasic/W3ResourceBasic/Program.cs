using W3ResourceBasic.Exercises;

Console.Write("Which exercise? ");
var choice = Console.ReadLine();
switch (choice)
{
    case "1": Exercise01.Run(); break;
    case "2": Exercise02.Run(); break;
    case "3": Exercise03.Run(); break;
    case "4": Exercise04.Run(); break;
    case "5": Exercise05.Run(); break;
    case "6": Exercise06.Run(); break;
    case "7": Exercise07.Run(); break;
    case "8": Exercise08.Run(); break;
    default: Console.WriteLine("Unknown"); break;
}