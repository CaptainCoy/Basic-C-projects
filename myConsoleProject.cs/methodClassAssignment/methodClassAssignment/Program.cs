using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Moves move = new Moves();  // This calls Moves to Program

            Console.WriteLine("Enter a number for the program..."); // Message that prompts user to enter a number, this number is for the program only and won't display anything to the user
            int pThree = Convert.ToInt32(Console.ReadLine()); // User input
            Console.WriteLine("Enter your lucky number: ");  // Message asking user for another number
            int pFour = Convert.ToInt32(Console.ReadLine());  // User input
            Console.WriteLine("Your lucky number is " + pFour);  // Message to user taking their input and displaying it back to them
            Console.ReadLine(); // This allows the user to read the message

            Console.WriteLine("Enter another number, doesn't really matter though ");  // Message to user
            var pTwo = Convert.ToInt32(Console.ReadLine());  // User input
            Console.WriteLine("Enter another number that this program will just disregard anyway ");  // This asks for a second number to be entered            
            var pOne = Convert.ToInt32(Console.ReadLine());  // This is the block of code that runs if the user decides to input a number
            int endR = move.Add(pTwo: 5, pOne: 6);  // This sets the variables to the number entered after the :
            Console.WriteLine("The result is " + endR); // This displays the results
            Console.ReadLine();  // This allows the user to read the line above
        }                 
    }
}
