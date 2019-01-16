using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 10.");
            string userGuess = Console.ReadLine();
            Console.WriteLine("You guessed: " + userGuess);

            if (userGuess.Equals("7"))
            {
                Console.WriteLine("You win!");
            }
            if (userGuess.Equals("0"))
            {
                Console.WriteLine("I said between 1 and 10. Try again.");
                userGuess = Console.ReadLine();
            }

            else

            {
                Console.WriteLine("You lost.");
               
            }
            
          
               
            
            
        }
    }
}
