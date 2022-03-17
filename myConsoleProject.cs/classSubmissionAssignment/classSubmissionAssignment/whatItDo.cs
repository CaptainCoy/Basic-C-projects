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

        public void theThing(out int x)  // Overloading the method 
        {
            x = 10;
            x *= x;

        }

        public static void Nombre(string name)  // This takes the string name and displays a message at the end
        {
            string aloha = "that was fun";  // This is part of the message
            Console.WriteLine(name +"\n" + aloha);  // This displays string name and the message
        }
    }
}
