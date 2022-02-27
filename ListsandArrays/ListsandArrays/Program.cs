using System;
using System.Collections.Generic;

namespace ListsandArrays
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] dogs = new string[] { "Olive", "Murphey", "Brenda", "Debbie", "Susan" }; // This is a string array with the names of my dogs
            Console.WriteLine("Who's a good dog? select [0 - 4]");  // This is the message to the user to make a selection
            int input = Convert.ToInt32(Console.ReadLine());  // This takes user input
            
            if (input == 0)  // The next few lines are the message that the user gets depending on their input
            {
                Console.WriteLine("Yes " + dogs[input] + " is a GOOD DOG!");
            }
            else if (input == 1)
            {
                Console.WriteLine("Yes " + dogs[input] + " is a GOOD DOG!");
            }
            else if (input == 2)
            {
                Console.WriteLine("Yes " + dogs[input] + " is a GOOD DOG!");
            }
            else if (input == 3)
            {
                Console.WriteLine("Yes " + dogs[input] + " is a GOOD DOG!");
            }
            else if (input == 4)
            {
                Console.WriteLine("Yes " + dogs[input] + " is a GOOD DOG!");
            }
            else  // This is the message the user gets if they don't pick within the specified parameters
            {
                Console.WriteLine("Not An Option");
            }

            Console.ReadLine();  // This allows the user to read the message

            int[] luckyNums = new int[] { 42, 3, 745, 1031, 13, 12 };  // This is an array of some numbers
            Console.WriteLine("Pick [0 - 5] for your lucky number");  // This promts the user to make a selection
            int numNum = Convert.ToInt32(Console.ReadLine());  // User input

            if (numNum == 0)  // This is the list of messages that the user will get depending on their input
            {
                Console.WriteLine("Your lucky number for the day is:" + luckyNums[numNum]);
            }
            else if (numNum == 1)
            {
                Console.WriteLine("Your lucky number for the day is:" + luckyNums[numNum]);
            }
            else if (numNum == 2)
            {
                Console.WriteLine("Your lucky number for the day is:" + luckyNums[numNum]);
            }
            else if (numNum == 3)
            {
                Console.WriteLine("Your lucky number for the day is:" + luckyNums[numNum]);
            }
            else if (numNum == 4)
            {
                Console.WriteLine("Your lucky number for the day is:" + luckyNums[numNum]);
            }
            else if (numNum == 5)
            {
                Console.WriteLine("Your lucky number for the day is:" + luckyNums[numNum]);
            }
            else  // This is the message if they make a selection outside of the parameters
            {
                Console.WriteLine("Oh no, you chose poorly. It's going to be a bad day for you...");  // Follow the instructions correctly or this onimous message appears
            }

            Console.ReadLine();  // This allows the user to read the message

            List<string> wordList = new List<string>();  // This starts a new string list
            wordList.Add("Thank you");  // This is how to add strings to the string list
            wordList.Add("Gracias");
            wordList.Add("Merci");
            wordList.Add("Danke");
            wordList.Add("Kiitos");
            wordList.Add("Shokran");  // Adding one more

            Console.WriteLine("Pick one more number for an exit message.");  // Exit message question
            int exit = Convert.ToInt32(Console.ReadLine());  // User input

            if (exit == 0)
            {
                Console.WriteLine(wordList[exit] +" (English)");  // Exit message
            }
            else if (exit == 1)
            {
                Console.WriteLine(wordList[exit] + " (Spanish)");
            }
            else if (exit == 2)
            {
                Console.WriteLine(wordList[exit] + " (French)");
            }
            else if (exit == 3)
            {
                Console.WriteLine(wordList[exit] + " (German)");
            }
            else if (exit == 4)
            {
                Console.WriteLine(wordList[exit] + " (Finnish)");
            }
            else if (exit == 5)
            {
                Console.WriteLine(wordList[exit] + " (Arabic)");
            }
            else
            {
                Console.WriteLine("Go away");
            }

            Console.ReadLine();  // Allows user to read message

            
        }
    }
}

