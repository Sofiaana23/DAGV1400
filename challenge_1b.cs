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
            float temperature = (float)Convert.ToDouble(Console.ReadLine());

            // This if tree will check temperatrues in the following ranges:
            // temp > 50
            if (temperature > 50)
            {
                string warningAdviceMessage = "Feels like hell, if possible stay inside";
                Console.WriteLine(warningAdviceMessage);
            }
            // 40 < temp < 50
            else if (temperature > 40)
            {
                string warningAdviceMessage = "Extremely hot, if going out, stay hydrated";
                Console.WriteLine(warningAdviceMessage);
            }
            // 30 < temp < 40
            else if (temperature > 30)
            {
                string warningAdviceMessage =
                    "Stay hydrated and avoid staying in the sun for too long or you might die";
                Console.WriteLine(warningAdviceMessage);
            }
            // 20 < temp < 30
            else if (temperature > 20)
            {
                string warningAdviceMessage = "Enjoy the pleasant weather";
                Console.WriteLine(warningAdviceMessage);
            }
            // 10 < temp < 20
            else if (temperature > 10)
            {
                string warningAdviceMessage = "A little chilly, bring a light sweater";
                Console.WriteLine(warningAdviceMessage);
            }
            // 0 < temp < 10
            else if (temperature > 0)
            {
                string warningAdviceMessage = "It's getting cold, wear a jacket";
                Console.WriteLine(warningAdviceMessage);
            }
            // temp < 0
            else
            {
                string warningAdviceMessage = "Extremely cold, be careful of hypothermia ";
                Console.WriteLine(warningAdviceMessage);
            }
            // Note that if temperature is equal to 30, nothing will happen
            // This is a new line for ease of readability in the console output.
            Console.WriteLine();

            //Challenge2

            // Prompt user by writing to console
            Console.WriteLine("Please insert your exam score as a percentage");

            // Read a line from the console (perform same conversions as line 13)
            float score = (float)Convert.ToDouble(Console.ReadLine());

            // Declare a message to use below
            string gradeMessage = "Your grade is: ";

            // An "A" will be any score greater than 90
            if (score >= 90)
                Console.WriteLine(gradeMessage + "A");
            // A "B" will be any score greater than 80 (since all A grades have already been identified)
            else if (score >= 80)
                Console.WriteLine(gradeMessage + "B");
            // A "C" will be any score greater than 70 (All A's and B's have already been identified)
            else if (score >= 70)
                Console.WriteLine(gradeMessage + "C");
            // A "D" will be any score greater than 60 (All A's, B's, and C's have already been identified)
            else if (score >= 60)
                Console.WriteLine(gradeMessage + "D");
            // An "F" is any other score (All other grades have been identified)
            else
                Console.WriteLine(gradeMessage + "F");

            // Get the user's favorite Subject
            Console.WriteLine();
            Console.WriteLine("Enter your favorite subject");
            string subject = Console.ReadLine();

            string subjectMessage;
            // Switch on that user input
            switch (subject)
            {
                case "Art":
                case "art":
                    subjectMessage = "You must got talent";
                    Console.WriteLine(subjectMessage);
                    break;
                case "Science":
                case "science":
                    subjectMessage = "You could be the next Einsten then";
                    Console.WriteLine(subjectMessage);
                    break;
                case "Math":
                case "math":
                    subjectMessage = "That is great! Math is a hard subject";
                    Console.WriteLine(subjectMessage);
                    break;
                case "English":
                case "english":
                    subjectMessage = "You must like to write a lot";
                    Console.WriteLine(subjectMessage);
                    break;
                // If we don't recognize the subject, we'll give the user this message
                default:
                    string errorDefaultMessage = "I'm sorry, I don't know that subject!";
                    Console.WriteLine(errorDefaultMessage);
                    break;
            }
        }
    }
}
