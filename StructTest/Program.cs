using System;

namespace StructTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and initialize an instance of the Number struct
            Number myNumber = new Number { Amount = 123.45m };

            // Print the amount to the console
            Console.WriteLine($"The amount is: {myNumber.Amount}");

            // Keep the console window open until the user presses a key
            Console.ReadLine();
        }
    }
}
