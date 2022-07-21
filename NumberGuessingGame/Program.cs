using System;

namespace NumberGuessingGame
{
    class Program
    {
        //Main method called when project is ran
        static void Main(string[] args)
        {
            //Start the Game when the program is run
            Game.RunGame();
        }
    }
    class Game
    {
        public static void RunGame()
        {
            //Write messages to the player.
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("Participate by guessing a number- I will tell you if you're close!");

            //Initialize the random number to be guessed by the player, and initialize the guess variable to a number outside the range of the random number.
            Random random = new Random();
            int numToGuess = random.Next(0, 10000);
            int guess = 10001;
            int guessCount = 0;

            //As long as the guess is different than the random number, continue asking for a guess.
            while (guess != numToGuess) {
                Console.WriteLine("Please type in a guess as a number!");
                string stringInput = Console.ReadLine();

                //Ask for a new guess if the guess is not a number.
                while (!int.TryParse(stringInput, out guess))
                {
                    Console.WriteLine("Guesses must be digits.");
                    stringInput = Console.ReadLine();
                }

                //Check if the guess is too high or low, and respond accordingly.
                if (guess > numToGuess)
                {
                    Console.WriteLine("Your guess is too high! Try again.");
                }
                else if (guess < numToGuess)
                {
                    Console.WriteLine("Your guess is too low! Try again.");
                }

                //Increment the guess count
                guessCount++;
            }

            //Finish the game
            Console.WriteLine("Congrats! You won the game in " + Convert.ToString(guessCount) + " guesses!");
        }
    }
}
