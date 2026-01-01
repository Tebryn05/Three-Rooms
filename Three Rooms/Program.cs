using System;

int[] stats = new int[3];
string[] statsName = new string[3] { "Strength", "Intelligence", "Charisma" };


Intro();





void Intro()
{
    Console.WriteLine("You have three rooms here to test you.");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("One room is a library filled with books that must be read thoroughly and that you must handle knowledge from");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("One room is a room with a tiger ");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Another room is a room full of cannibals that you have to convince to not be cannibals anymore");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.WriteLine("You will have 3 stats that will help you out in this.");
    Console.WriteLine("Press any key to continue.");
    Console.ReadKey(true);

    Console.WriteLine("These stats are: ");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Strength,");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(" Intelligence,");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(" and Charisma.\n");
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("Press any key to continue.");
    Console.ReadKey(true);

    Console.WriteLine("\nYou will roll a random number between 3-60 to see how many points you get in these stats.");
    Console.WriteLine("The max you can get is 20 for each stat and the minimum is 1.");
}