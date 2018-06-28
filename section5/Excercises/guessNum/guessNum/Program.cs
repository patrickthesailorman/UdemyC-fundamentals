using System;

namespace guessNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int myNumber = randomNumber.Next(1, 11);
            Console.WriteLine(myNumber);
            int guesses = 0;

            Console.WriteLine("You have 4 guesses...");

            while(guesses < 4)
            {
                Console.WriteLine("I'm thinking of a number between 1 and 10. \nWhat is it?:\n");
                int guess = Convert.ToInt32(Console.ReadLine());
                guesses++;

                if(guess == myNumber)
                {
                    Console.WriteLine("You got it!");
                    break;
                }
                else if (guess != myNumber && guesses < 4)
                {
                    Console.WriteLine("That's not it. You have used {0} guesses. Try again.", guesses);
                    continue;
                }
                if (guesses == 4 && guess != myNumber)
                {
                    Console.WriteLine("Sorry! The number is {0}.", myNumber);
                }
            }
        }
    }
}
