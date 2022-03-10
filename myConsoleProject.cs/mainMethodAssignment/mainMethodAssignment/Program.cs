using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethodAssignment
{
    class Program
    {        

        static void Main(string[] args)
        {
            Funk mathOps = new Funk();
            Console.WriteLine("Enter a number here: ");  // Message to user
            var numNum = Convert.ToInt32(Console.ReadLine()); // User input
            Console.WriteLine("Boost!"); // Write results
            Console.WriteLine(mathOps.Mult(numNum));           
            var funkyResult = mathOps.Mult(numNum);  // Calling the Mult function from Funk page               
            Console.ReadLine();  // Display reesults to user
            Console.WriteLine("Enter another number: ");
            var num1 = Convert.ToDecimal(Console.ReadLine());
            var funkyResult2 = mathOps.Mult(numNum, num1);            
            Console.WriteLine(numNum + " times " + num1 + " equals " + funkyResult2);
            Console.ReadLine();
            Console.WriteLine("Pick another number: ");
            var third = Console.ReadLine();
            var funkyResult3 = mathOps.Mult(third);
            Console.WriteLine(funkyResult3);
            Console.ReadLine();
        }
    }
}
