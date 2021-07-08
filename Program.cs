using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Head
            string appName = "Number Guesser";
            string appVersion = " 1.0.1";
            string appAuthor = "Main";
            //Color
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            //Reset color
            Console.ResetColor();

            //Ask & Get
            Console.ForegroundColor = ConsoleColor.Green;
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello {0}!", name);
            Console.ResetColor();
            Console.WriteLine("Lets play a game!");
            //Game
            while (true)
            {
                //int correctNumber = 7;
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;
                Console.WriteLine("Guess a number betweeen 1 and 10");
                while (guess != correctNumber)
                {
                    string unos = Console.ReadLine();
                    if (!int.TryParse(unos, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter a number!");
                        Console.ResetColor();
                        continue;
                    }
                    guess = Int32.Parse(unos);
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Guess again!");
                        Console.ResetColor();
                    }


                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Hurray the number is {0}", correctNumber);
                Console.ResetColor();

                Console.WriteLine("Do you want to play again?(y/n)");
                string exit = Console.ReadLine().ToLower();
                if (exit != "y")
                    return;
                continue;
            }


        }
    }
}
