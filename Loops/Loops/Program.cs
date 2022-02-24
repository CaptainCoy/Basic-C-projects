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
            Console.WriteLine("What is the best Nintendo franchise?");
            string winner = Console.ReadLine();
            bool choice = winner == "Zelda";

            do
            {
                switch (winner)
                {
                    case "Mario":
                        Console.WriteLine("Classic, but not the best.");
                        Console.WriteLine("Try again.");
                        winner = Console.ReadLine();
                        break;

                    case "Donkey Kong":
                        Console.WriteLine("Fun, but the best? No.");
                        Console.WriteLine("give it another try.");
                        winner = Console.ReadLine();
                        break;

                    case "Sonic":
                        Console.WriteLine("That's a SEGA franchise, come on man.");
                        Console.WriteLine("Let's do better this time.");
                        winner = Console.ReadLine();
                        break;

                    case "Zelda":
                        Console.WriteLine("We have a winner!!!! \nCongratulations");
                        choice = true;                        
                        choice = true;                        
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Nah, try again.");
                        winner = Console.ReadLine();
                        break;

                }
            }
            while (!choice);

            Console.ReadLine();
        }
    }
}
