using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");  // Intro line for the program
            string name = Console.ReadLine();  // This allows user to input their name
            name = name.ToUpper();  // This converts the user input to all upper case
            string welcome = " Welcome to the program.";  // These are strings that will be used along with the user input for the welcome message
            string hello = "Hello ";
            Console.WriteLine(hello + name + welcome);  // This is the welcome message all put together
            Console.ReadLine();  // This allows the user to read the message

            StringBuilder sb = new StringBuilder("This is the begining of a string that we can add to later.");  // This is starting a string builder
            sb.Append("\nSee here is a new sentance");  // The next fgew lines is adding to the string builder string
            sb.Append(".  Now we are continuing on the previous line.");
            sb.Append("\nHere we go on a new line.");
            sb.Append("\nWe can keep going and going and going and going...");

            Console.WriteLine(sb);  // This writes the string builder string to the console
            Console.ReadLine();  // This allows user to read the string

        }
    }
}
