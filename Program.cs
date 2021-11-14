using System;

namespace optimization_flutter_pull_test
{
    // Main Class
    class Program
    {

        // void: not return anything
        // static: don't have instances
        static void Main(string[] args)
        {

            GetAppInfo(); // Run Get App Info

            GreetUser(); // Ask for users name and greet

            while (true)
            {
                // Create a new Random number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // Init quess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make Sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please Enter an actual nuber.");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }

                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct.");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }

        // get and display app info
        static void GetAppInfo()
        {
            string appName = "Number Guesser";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}", appName);

            // Reset Text Color
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser()
        {
            Console.WriteLine("Your Name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user not number type
            Console.WriteLine(message);

            // Reset Text Color
            Console.ResetColor();
        }
    }
}
