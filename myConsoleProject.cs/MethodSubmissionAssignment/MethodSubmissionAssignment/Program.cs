using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Moves move = new Moves();  // This calls the Moves funtion to the Program
            Console.WriteLine("Enter another number: ");  // Message to user
            var pTwo = Convert.ToInt32(Console.ReadLine());  // User input

            Console.WriteLine("Enter another if you'd like to: ");  // This asks for an optional second number to be entered
            try
            {
                var opt = Convert.ToInt32(Console.ReadLine());  // This is the block of code that runs if the user decides to input a number
                int endR = move.Add(pTwo, opt);  // This lets the Moves function know to use the two variables entered by the user
                Console.WriteLine("The result is " + endR);
                Console.ReadLine();
            }
            catch  // This block of code runs if the user decides not to input a second number
            {
                int endR = move.Add(pTwo);  // This lets the Moves funtion know to only use the first user input 
                Console.WriteLine("The reult is " + endR);
                Console.ReadLine();
            }
        }
    }
}
