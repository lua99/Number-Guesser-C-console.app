using System;

namespace NumberGuess_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo();


            GreetUser();

            while(true){

                //int correctNumber = 7;

                //create random number

                Random random = new Random();
                int correctNumber = random.Next(1, 11);

                int guess = 0;

                Console.WriteLine("Guess a number between 1-10");

                while (guess != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();

                    //make sure its a number

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.WriteLine("Its not a Number ,be Smarter");

                        Console.ResetColor();

                        continue;
                    }

                    //to int

                    guess = int.Parse(input);

                    //match guess to correctNum
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Oops Wrong Number,try again");

                        Console.ResetColor();
                    }
                }

                //success message
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Thats Correct Number,Good Job");

                Console.ResetColor();

                //ask to play again

                Console.WriteLine("Do you want to play again? Y or N");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }

                else if(answer=="N")
              {
                    return;
              }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //set vars
            string appName = "Number Guesser";
            string appVersion = "2.0.0";
            string appAuthor = "Gio Luarsabishvili";

            //change textColor
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void GreetUser()
        {
            //ask user name
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0},lets play a game", inputName);
        }
    }
}
