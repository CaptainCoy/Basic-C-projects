using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classSubmissionAssignment
{
    class Program
    {
        public static int answer { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            whatItDo does = new whatItDo();  // this instantiates the function
            Console.WriteLine("Enter a number to the void ");  // this prompts user to enter a number
            int num = Convert.ToInt32(Console.ReadLine());  // user input
            does.theThing(num); // this takes user input and applies it to the function             
            Console.ReadLine();  // this allows the user to read the message that the function puts out

            whatItDo doDo = new whatItDo();
            Console.WriteLine("Give it another try... ");
            Console.WriteLine("Enter another number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number ");
            int numNum = Convert.ToInt32(Console.ReadLine());
            doDo.theThing(out num1, out numNum);
            Console.WriteLine("First number entered was: {0}", num1);
            Console.WriteLine("Second number entered was: {0}", numNum);
            Console.ReadLine();

            Console.WriteLine("\n\n\nThanks for playing");
            Console.WriteLine(whatItDo.nombre.aloha);
            
        }
    }
}
