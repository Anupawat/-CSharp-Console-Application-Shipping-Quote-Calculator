using System;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Display the initial welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            // Step 2: Prompt the user for the package weight
            Console.Write("Please enter the package weight (in pounds): ");
            double weight = Convert.ToDouble(Console.ReadLine());  // Parse the input to a double type
            
            // Step 3: Check if the weight is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;  // Exit the program if weight is too heavy
            }

            // Step 4: Prompt the user for the package dimensions (width, height, and length)
            Console.Write("Please enter the package width (in inches): ");
            double width = Convert.ToDouble(Console.ReadLine());  // Parse the input to a double type

            Console.Write("Please enter the package height (in inches): ");
            double height = Convert.ToDouble(Console.ReadLine());  // Parse the input to a double type

            Console.Write("Please enter the package length (in inches): ");
            double length = Convert.ToDouble(Console.ReadLine());  // Parse the input to a double type

            // Step 5: Check if the total dimensions (width + height + length) exceed 50
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;  // Exit the program if dimensions are too large
            }

            // Step 6: Calculate the shipping quote using the given formula
            double quote = (width * height * length * weight) / 100;

            // Step 7: Display the shipping quote to the user
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            
            // Step 8: Thank the user for using the service
            Console.WriteLine("Thank you for using Package Express!");
        }
    }
}
