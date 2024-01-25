using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    	// Integers
        // Operators: +, -, *, /, ++, --
        int itemsPerPackage = 12;
        int brokenItems = 2;
        int cookedItems = 3;
        int numberPackages = 3;
        
        // Total Eggs = 12 * 3 -> 36
        int totalItemsPurchased = itemsPerPackage * numberPackages;
        
        // Eggs Remaining = 36 - 5 -> 31
        int itemsRemaining = totalItemsPurchased - (brokenItems + cookedItems);
        
        // Double
        // Operators: +, -, *, /
        double totalPrice = 6.50d;
        
        // price per package = 6.50 / 3 -> 2.17
        double pricePerPackage = totalPrice / numberPackages;
        // price per egg = 6.5 / 32 -> 0.18
        double pricePerItem = totalPrice / totalItemsPurchased;
        
        // Char
        // Operators: +
        char dollarSign = '$';
        
        // String
        // Operators: +
        string itemName = "Eggs";
        
        
        // Boolean
        // Operators: !, ||, &&
        // Check if the number of eggs left is greater than 0
        bool areAnyItemsLeft = itemsRemaining > 0;
        
        // Write Output
        
        // All of these are using the + operator on String literals, String variables, Char Variables, Integers, and Doubles.
        Console.WriteLine("Type of Items Purchased: " + itemName);
        Console.WriteLine("Price per Item: " + dollarSign + pricePerItem);
        Console.WriteLine("Price per Package: " + dollarSign + pricePerPackage);
        Console.WriteLine("Total Cost of Items Purchased: " + dollarSign + totalPrice);
        Console.WriteLine("Are you out of " + itemName + "?: " + !areAnyItemsLeft);
        Console.WriteLine(itemName + " remaining: " + itemsRemaining);

    }
  }
}