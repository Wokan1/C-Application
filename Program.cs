using System;

// Namespace
namespace Uhadni
    //Main Class
{
    class Program
    {
        // Entery point metohod
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser(); // Ask fo users name an greet

            while (true)
            {

                // init correct number

                // int correctNumber = 7;
                // create a new random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //init gueass var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    // make sure it is number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        printColorMassage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;

                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                
                        // Print error message
                        printColorMassage(ConsoleColor.Red, "Wrong number, pleas try again");
                     
                    }

                }
                // Print succes message 
                printColorMassage(ConsoleColor.Yellow, "You have right !!!");

                // Ask to play a game
                Console.WriteLine("Play again? [Y or N]");

                // Get Ansver
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else;
                {
                    return;
                }
            }
        }
        // get and display info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "UhadniCislo";
            string appVersion = "1.0.0";
            string appAuthors = "Jozef Osvald";

            // Change text collar
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info

            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthors);

            //reset collor
            Console.ResetColor();
        }
        // Ask user name and greet
        static void GreetUser()
        {
            // Ak uster name
            Console.WriteLine("What is your name? ");

            // Get user input
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, lets play a game...", inputName);
        }

        // Print color message
        static void printColorMassage(ConsoleColor color, string messege)
        {
            // Change text collar
            Console.ForegroundColor = color;

            // Tell user its not number

            Console.WriteLine(messege);

            //reset collor
            Console.ResetColor();
        }
    }
}
