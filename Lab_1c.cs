using System;

namespace MyApplication
{
  class Program
  {
        static void Main(string[] args)
    {
        //Prompt user to enter a positive number
        Console.WriteLine ("Please enter a positive integer");
        string input = Console.ReadLine();
        int pyramidNumber = Int32.Parse(input);
        Console.WriteLine("------------------");
        //Use of loops
        for (int i = 1; i <= pyramidNumber; i++)//row
        {
            for (int h = 1; h <= i; h++) // collumn
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
  }
}