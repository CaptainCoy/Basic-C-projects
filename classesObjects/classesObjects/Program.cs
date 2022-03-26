using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.classesObjects;

namespace classesObjects
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the casino,  What's your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much are money would you like to buy in with?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}, Would you like to be dealt into the next game?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Alex\OneDrive\Documents\Basic_C#_Programs\myConsoleProject.cs\log.txt", true))
                {
                    file.WriteLine(player.Id);                    
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you , come again");
            }
            Console.WriteLine("Feel free to come back");
            Console.ReadLine();
        }     
    }
}
