using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        //Challenge1
        // Prompt user by writing to console
        Console.WriteLine("Please insert the temperature in Celsius ");

        // Read a line from the console (convert string to double, then cast to float)
        float temperature = (float) Convert.ToDouble(Console.ReadLine());

        // If Temperature is greater than 30
        if ( temperature > 30 )
        { 
            string alertMessage = "Stay hydrated and avoid staying in the sun for too long or you might die";
            Console.WriteLine(alertMessage);
        }
        // Otherwise, if temperature is less than 30
        else if (temperature < 30)
        {
            string suggestedMessage = "Enjoy the pleasant weather";
            Console.WriteLine(suggestedMessage);
        }
        // Note that if temperature is equal to 30, nothing will happen
        // This is a new line for ease of readability in the console output.
        Console.WriteLine();


        //Challenge2

        // Prompt user by writing to console
        Console.WriteLine("Please insert your exam score as a percentage");

        // Read a line from the console (perform same conversions as line 13)
        float score = (float) Convert.ToDouble(Console.ReadLine());

        // Declare a message to use below
        string gradeMessage = "Your grade is: ";

        // An "A" will be any score greater than 90
        if ( score >= 90 )
            Console.WriteLine(gradeMessage + "A");
        
        // A "B" will be any score greater than 80 (since all A grades have already been identified)
        else if ( score >= 80 )
            Console.WriteLine(gradeMessage + "B");

        // A "C" will be any score greater than 70 (All A's and B's have already been identified)
        else if ( score >=70 )
            Console.WriteLine(gradeMessage + "C");
        
        // A "D" will be any score greater than 60 (All A's, B's, and C's have already been identified)
        else if ( score >=60)
            Console.WriteLine(gradeMessage + "D");
        
        // An "F" is any other score (All other grades have been identified)
        else
            Console.WriteLine(gradeMessage + "F");

    }
  }
}