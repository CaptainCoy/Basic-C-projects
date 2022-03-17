using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classSubmissionAssignment
{
    class whatItDo
    {
        public void theThing(int num)
        {
            int answer = num / 2;  // this takes user number and divides it by two
            Console.WriteLine("I give you " + answer);  // message to user 
        }

        public void TheThing(out int num1, out int numNum)  // Overloading the method 
        {
            Console.WriteLine("Enter another number ");
            int numm1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number ");
            int numNumm = Convert.ToInt32(Console.ReadLine());
            int answer2 = numNumm * 1000 / numm1;
            Console.WriteLine("Here's " + answer2);
        }
    }
}
