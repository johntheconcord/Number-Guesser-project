using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Set application variables
            // Reset text color, if you want with Console.ResetColor();

            GetAppInfo(); // Run GetAppInfo function to get info for application

            GreetUser(); // Ask for users name and greet 





            while (true) {



                // Create a new Random object

                Random random = new Random();
                
                // Set (init) correct number 
                int correctNumber = random.Next(1, 10); 

                // Set (init) guess variable
                int guess = 0; 
              

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10"); 

                while (guess != correctNumber)
                // while guess is not correct
                {
                    string input = Console.ReadLine();

                    // Make sure it is a number

                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number.");


                        // Keep going

                        continue;
                    }

                    // Case to int and put in guess
                    guess = Int32.Parse(input);

                
                   

                    // Match guess to correct number

                    if (guess != correctNumber)
                    {
                        // Print error message

                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again!");

                    }
                   
                }

                

                // Output success message!

               

                PrintColorMessage(ConsoleColor.Yellow, "You are CORECT!!!");
                Console.ResetColor();

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

        static void GetAppInfo () {
            string appName = "Number Guess Project";
            string appVersion = "1.0.0";
            string appAuthor = "John Curtis Jr";

            Console.WriteLine("{0} Version {1} by {2}", appName, appVersion, appAuthor);

            // Change text color

            Console.ForegroundColor = ConsoleColor.Cyan;

          
        }

        static void GreetUser()
        {
            // Ask User's Name
            Console.WriteLine("What is your name?");

            // Get User Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage (ConsoleColor color, string message)
        {
            // Tell User it is not a number
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
} 
