using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);

            Console.WriteLine("Car insurance program"); // This displays the title of the program
            Console.ReadLine();  

            Console.WriteLine("\n\nWhat is your age?");  // Start questionaire
            int age = Convert.ToInt32(Console.ReadLine()); // User input
            Console.WriteLine("\nHave you ever had a DUI? (true/false)");  // Second question            
            bool dui = Convert.ToBoolean(Console.ReadLine()); // User input
            Console.WriteLine("\nHow many speeding tickets do you have?"); // Third question
            int zoom = Convert.ToInt32(Console.ReadLine());  // User input

            bool results = age >= 16 && dui == false && zoom < 3;  // This takes user input and determines if they are qualified
            Console.WriteLine("\nQuailified?");  
            Console.WriteLine(results);  // Prints "true" or "false" depending on user input


            Console.ReadLine();
        }
    }
}
