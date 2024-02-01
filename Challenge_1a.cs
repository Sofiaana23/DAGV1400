using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Challenge 1");
        Console.WriteLine("-----------");

        // This challenge is about declaring and initializing variables and then 
        // displaying them to the console.

        // Declaration and Initialization
        int integerVariable = 12;
        bool booleanVariable = true;
        float floatingPointVariable = 3.14f;
        string stringVariable = "Hello World";

        // Display to Screen
        Console.WriteLine("Integers are whole numbers without decimals");
        Console.WriteLine("eg: int age = " + integerVariable);
        Console.WriteLine("");

        Console.WriteLine("Booleans variables that contain true or false");
        Console.WriteLine("eg: bool isBroken = " + booleanVariable);
        Console.WriteLine("");

        Console.WriteLine("Float are variables that contain decimals");
        Console.WriteLine("eg: float pi = " + floatingPointVariable + "f");
        Console.WriteLine("");

        Console.WriteLine("String is a variable that contain text");
        Console.WriteLine("eg: string helloWorld = \"" + stringVariable + "\"");
        Console.WriteLine("");
        
        // End Challenge 1
        
        Console.WriteLine("Challenge 2");
        Console.WriteLine("-----------");

        // This section includes variable manipulation.
        // Specifically +, -, *, / on numerical types

        // Initialization of variables For Challenge 2
        int x = 5, y = 7;
        float a = 3.14f, b = 4;

        // To complete Challenge 3, we will ignore the variables above, and let the user override them
        Console.WriteLine("Please insert integer value for x: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please insert integer value for y: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Please insert float value for a: ");
        a = (float) Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please insert float value for b: ");
        b = (float) Convert.ToDouble(Console.ReadLine());

        // Performing calculations and displaying to screen
        Console.WriteLine("x = " + x + ", y = " + y);
        Console.WriteLine("a = " + a + ", b = " + b);
        Console.WriteLine();
        Console.WriteLine("Addition");
        Console.WriteLine("x + y = " + (x+y));
        Console.WriteLine("a + b = " + (a+b));
        Console.WriteLine("");

        
        Console.WriteLine("Subtraction");
        Console.WriteLine("x - y = " + (x-y));
        Console.WriteLine("a - b = " + (a-b));
        Console.WriteLine("");

        Console.WriteLine("Multiplication");
        Console.WriteLine("x * y = " + (x*y));
        Console.WriteLine("a * b = " + (a*b));
        Console.WriteLine("");

        Console.WriteLine("Division");
        Console.WriteLine("x / y = " + (x/y));
        Console.WriteLine("x % y = " + (x%y)); // Modulus is the remainder from integer division
        Console.WriteLine("a / b = " + (a/b));
        Console.WriteLine("");

    }
  }
}
