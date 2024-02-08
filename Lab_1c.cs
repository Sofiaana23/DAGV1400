using System;

namespace MyApplication
{
  class Program
  {
        static void Main(string[] args)
    {
        Console.WriteLine ("Please enter a positive integer");
        string input = Console.ReadLine();
        int pyramidNumber = Int32.Parse(input);
        Console.WriteLine("------------------");

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