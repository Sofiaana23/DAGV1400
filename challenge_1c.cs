using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {

        // Challenge 1: Number Guesser
        // Generating a random number
        Random gameNumberGenerator = new Random();
        int num = gameNumberGenerator.Next(1,11);

        // Counter for number of guesses
        int numberOfGuesses = 0;

        while(true)
        {
            // Increment number of guesses
            numberOfGuesses++;

            // Asking user for their guess
            Console.WriteLine ("Please guess the number");
            string guess = Console.ReadLine(); 
            
            // The User Guessed correctly
            if (num==Int32.Parse(guess))
            {
                string feedback = "Congradulations, your guess was correct";
                Console.WriteLine(feedback);

                Console.Write("It took you ");
                Console.Write(numberOfGuesses);
                Console.WriteLine(" attempts.");
                break;
            }
            // User was wrong (too low)
            else if (num>Int32.Parse(guess))
            {
                string feedback = "Sorry, your guess was too low";
                Console.WriteLine(feedback);
            }
            // User was wrong (too high)
            else 
            {
                string feedback = "Sorry, your guess was too high";
                Console.WriteLine(feedback);
            }
        }
        Console.WriteLine();

        // Challenge 2: Favorite Foods
        // Create an array of favorite foods (size 3)
        string[] favoriteFoods = new string[3];

        // Ask user for favorite foods
        Console.WriteLine ("Please enter your three favorite foods separated by <Enter>");
        
        // Store favorite foods in array
        for(int i=0; i<3; i++)
        {
            favoriteFoods[i] = Console.ReadLine();
        }

        Console.WriteLine();

        // Repeating the favorite foods
        foreach(string food in favoriteFoods)
        {
            Console.WriteLine("I love " + food + "!");
        }
    }
  }
}