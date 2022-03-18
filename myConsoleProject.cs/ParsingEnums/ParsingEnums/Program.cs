using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isvalid = false;  // Setting a bool to false so that if the user input is invalid it will let them try until they get it right
            while (!isvalid)  // While is valid is false this will keep running
            {


                try  // This block runs if user entry is valid
                {
                    Console.WriteLine("What day is it?");  // This is the question presented to the user
                    string thisDay = Console.ReadLine().ToLower();  // User input, toLower is a safety net in case the user uses a weird capitol letter

                    Days day = (Days)Enum.Parse(typeof(Days), thisDay);  // This instantiates the enum list Days and searches the enum list to see if user input matches an option on the list
                    Console.WriteLine("It is " + day + "!");  // If there is a match, this message comes up
                    Console.ReadLine();  // This allows user to read the message
                    isvalid = true;  // This sets the bool to true and ends the program
                }
                catch (ArgumentException)  // If the user doesn't input a valid entry this will run until they get it right
                {
                    Console.WriteLine("Enter the day correctly, please.");  // Wrong entry message                    
                }
            }
        }
        public enum Days // Enum list, the following are the correct entry options
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        }
    }
}
