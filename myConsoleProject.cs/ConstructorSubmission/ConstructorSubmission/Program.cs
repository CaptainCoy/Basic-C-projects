using System;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DeepThought = 42;  // Defines the const DeepThough as the integer 42
            var guide = "Dont Panic";  // Defines the var guide as the string "Don't Panic"

            Console.WriteLine("\nWhat is the answer to the great question of life the universe and everything...");  // This message appears first, two lines from the top because of the \n\n it looks better that way
            Console.ReadLine();  // This allow the user to read that message before the program moves on
            
            
            Console.WriteLine(DeepThought);  // This prints the const DeepThought 

            Console.ReadLine();  // This allows the user to read the answer provided by DeepThought
            Console.WriteLine("\n\n\n" + guide);  // This prints var guide, guide happens to be a string in this case
            Console.ReadLine();  // This allows the user to read the line

            Dolphin dolphin = new Dolphin();  // This creates an instance of Dolphin class

            
            Console.ReadLine();  // This allows the user to read the message


        }
    }
}
