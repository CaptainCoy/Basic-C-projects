using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WhatTimeIsIt
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now; // Initialize a DateTime with the current DateTime

            Console.WriteLine("Hello,\nenter a number: ");  // This is the greeting message to start the program
            double jump = Convert.ToDouble(Console.ReadLine());  // This is the user input
            Console.WriteLine("\n\nThe current time is : {0}\nPress Enter...", current);  // This writes another message to the user showing the current DateTime
            Console.ReadLine(); // This waits for user to press enter to proceed


            DateTime plus = current.AddHours(jump);  // This initializes a new DateTime that will add the number entered in jump to hours on the current DateTime

            Console.WriteLine("\n\nThe time will be {0} when {1} have gone by.", plus, jump);  // This shows the DateTime when the number for jump is added to hours in the current DateTime
            Console.ReadLine();  // This allows the user to see the message

        }
    }
}
