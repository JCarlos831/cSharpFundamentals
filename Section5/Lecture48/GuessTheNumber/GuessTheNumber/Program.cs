using System;

// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
// If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program
// is behaving correctly, you can display the secret number on the console first.)

namespace GuessTheNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Guessing game!\n");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            Console.WriteLine(randomNumber);
            int guessesLeft = 4;
            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: \n");
                string result = Console.ReadLine();
                guessesLeft--;
                guesses++;

                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                    Console.WriteLine("{0} is correct, You won! It took you {1} guesses", result, guesses);
                    break;
                }
                else if (guessesLeft == 0)
                {
                    Console.WriteLine("You lost\n");
                }
                {
                    Console.WriteLine("{0} is incorrect. You have {1} guesses remaining.\n", result, guessesLeft);
                }
            } while (incorrect && guessesLeft != 0);

        }
    }
}
