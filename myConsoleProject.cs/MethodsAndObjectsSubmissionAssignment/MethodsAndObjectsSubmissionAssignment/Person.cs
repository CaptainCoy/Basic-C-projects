using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmissionAssignment
{
    public class Person
    {
        public string FirstName { get; set; }  // This is a property of the class Person
        public string LastName { get; set; }  // This is another

        public void SayName()  // This is the function to use the above properties
        {

            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);  // Message to user
        }

    }
    
}
