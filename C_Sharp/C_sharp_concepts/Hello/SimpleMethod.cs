using System;

namespace Hello
{
    class SimpleMethod
    {
        public static void SimpleMethodMain(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
               displayMenu= MainMenu();
            }

          
         

        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\nChoose an option\n");
            Console.WriteLine("1. Print Numbers");
            Console.WriteLine("2. Play Guessing Game");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter:");
            string result = Console.ReadLine();
            switch (result)
            {
                case "1":
                    PrintNumbers();
                    break;
                case "2":
                    GuessingGame();
                    break;
                case "3":
                    return false;

                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }

                    Console.ReadLine();
            
            return true;
        }

        private static void PrintNumbers()
        {
            Console.WriteLine("Printing Numbers:");
            Console.Write("Type a Number:");
            int result = int.Parse(Console.ReadLine());
            
            int counter = 1;
            while((counter)<=result)
            {
                Console.Write(counter + "-");
                counter++;
            }
            Console.ReadLine();
        }
        private static void GuessingGame()
        {   
            Console.WriteLine("GuessingGame :");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1,11);

            int guesses = 0;
            bool incorrect = true;
            do 
            {

                Console.WriteLine("Guess a number between 1 to 10");
                string result=Console.ReadLine();
                guesses++;
                if(result==randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong!!");

                }
            } while (incorrect);

                Console.WriteLine("Correct!! It took {0} guesses.",guesses);

            Console.ReadLine();
        }
        private static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }
}
