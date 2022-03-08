using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        public int Num1 { get; set; }
        //public int Num2 { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number...");
            var num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("And another...");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("What do you want to do with these? (+, -, x,");
            //var doWhat = Console.ReadLine();
            var doWhatObject = new doWhat();
            var funResult = doWhatObject.Add(num1);
            funResult = doWhatObject.Subtract(funResult);
            funResult = doWhatObject.Divide(funResult);
            Console.WriteLine("Your number + 5 - 1 / 4 is " + funResult);
            Console.ReadLine();

            
        }        
    }
}
