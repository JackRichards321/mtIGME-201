using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);

            Console.WriteLine(randomNumber);

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("You have " + (8 - i) + " guesses left, guess a number 0 through 100!");
                string guess = Console.ReadLine();
                int intGuess = int.Parse(guess);

                while (!(intGuess >= 0 && intGuess <= 100))
                {
                    Console.WriteLine("Invalid guess, try again");
                    guess = Console.ReadLine();
                    intGuess = int.Parse(guess);
                }

                if (intGuess == randomNumber)
                {
                    Console.WriteLine("Congratulations, you are correct!");

                    if(i > 1)
                    {
                        Console.WriteLine("It took you " + (8 - i) + " turns.");
                    }

                } else if (intGuess > randomNumber)
                {
                    Console.WriteLine("Too high, try again!");
                } else if (intGuess < randomNumber)
                {
                    Console.WriteLine("Too low, try again!");
                }
            }

            Console.WriteLine("The correct answer was " + randomNumber);
        }
    }
}
