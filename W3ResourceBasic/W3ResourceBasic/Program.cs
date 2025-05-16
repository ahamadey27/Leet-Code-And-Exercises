using W3ResourceBasic.Exercises;

Console.Write("Which exercise? ");
var choice = Console.ReadLine();
switch (choice)
{
    case "1": Exercise01.Run(); break;
    case "2": Exercise02.Run(); break;
    case "3": Exercise03.Run(); break;
    default: Console.WriteLine("Unknown"); break;
}