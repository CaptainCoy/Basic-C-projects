using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the best Nintendo franchise?");  // This is the question that gets displayed to start the program
            string winner = Console.ReadLine();  // This takes the user input 
            winner = winner.ToLower();
            bool choice = winner == "Zelda";  // This is the answer that the program is looking for

            do  // Do is the instructions for the program to run while looking to meet the While conditions 
            {
                switch (winner)  // This is where the program takes user input for string winner and gives an answer to given input.  
                {
                    case "mario":  // If the user inputs "Mario" then the following instructions will run.  This goes for all of the "cases" for this switch.
                        Console.WriteLine("Classic, but not the best.");  // Response to user input
                        Console.WriteLine("Try again.");  // Next instruction
                        winner = Console.ReadLine();  // User input
                        break;  // End case

                    case "donkey kong":
                        Console.WriteLine("Fun, but the best? No.");
                        Console.WriteLine("give it another try.");
                        winner = Console.ReadLine();
                        break;

                    case "sonic":
                        Console.WriteLine("That's a SEGA franchise, come on man.");
                        Console.WriteLine("Let's do better this time.");
                        winner = Console.ReadLine();
                        break;

                    case "zelda": // Correct answer
                        Console.WriteLine("We have a winner!!!! \nCongratulations");   // Winner message
                        choice = true;  // This resets the boolean to true and ends the loop
                        Console.ReadLine();  // This allows user to see winner message
                        break;  // End case, and move on to the next loop

                    default:  // This runs if user input doesn't match any of the case strings
                        Console.WriteLine("Nah, try again.");
                        winner = Console.ReadLine();
                        break;
                }
            }
            while (!choice);  // This is the While loop condition that the Do instructions are trying to find.  The exclamation point equates to while string choice is false.

            Console.WriteLine("BONUS QUESTION: \nHow many games from the Zelda franchise were released for Nintendo 64?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool releaseNumber = number == 2;

            while (!releaseNumber)  
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("There was another one.");
                        Console.WriteLine("Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("That is correct!");
                        releaseNumber = true;
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("One off.");
                        Console.WriteLine("Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Too many.");
                        Console.WriteLine("Try again.");
                        number = Convert.ToInt32(Console.ReadLine()); 
                        break;
                }
            }
            Console.WriteLine("That was fun.");  // End message
            Console.ReadLine();  // Display end message
        }
    }
}
