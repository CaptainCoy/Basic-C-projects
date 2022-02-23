using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express!");  // This is the program title
            Console.ReadLine();  // This allows user to see title before moving forward
            Console.WriteLine("please follow the instructions below."); // This is the next step in the program.
            Console.ReadLine(); // I like when the program makes the user press enter to progress rather than throw all the info at them at once. I feel like this provides a better user experience.
            Console.WriteLine("\n\nPlease enter the package weight:");  // This is the first instruction.
            double weight = Convert.ToDouble(Console.ReadLine());  // This is the user input for the double "weight"
            if (weight > 50)  // This determines if the package is too heavy
            {
                Console.WriteLine("This package is too heavy to be shipped via Package Express. Have a good day.");  // If package is too heavy, exit program
            }
            else // If the package is not too heavy contiue here.
            {
                Console.WriteLine("Please enter the package width:");  // Next instruction
                double width = Convert.ToDouble(Console.ReadLine());  // User input
                Console.WriteLine("Please enter the package height:"); // Instruction
                double height = Convert.ToDouble(Console.ReadLine());  // Input
                Console.WriteLine("Please enter the package length:");  // Instruction
                double length = Convert.ToDouble(Console.ReadLine());  // Input
                if (width+height+length > 50)  // This checks if the package is too big
                {
                    Console.WriteLine("This package is too big to be shipped via Package Express. Have a good day.");  // If package is too big, exit program
                }
                else  // If the package is not too big continue here
                {
                    double quote = (width * height * length) * weight / 100; // This uses the variables to determine quote
                    Console.WriteLine("Your estimated total for shipping is: $" + quote + "\nThank you!");  // The result prints here
                }

            }           

            Console.ReadLine(); // This allows user to read the last line 
        }
    }
}
