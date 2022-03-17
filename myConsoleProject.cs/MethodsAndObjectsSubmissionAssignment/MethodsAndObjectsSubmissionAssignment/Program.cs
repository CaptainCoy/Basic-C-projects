using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { FirstName = "Sample", LastName = "Student"};  // This instiates the Employee class and assigns strings to FirstName and LastName          
            emp.SayName();  // This calls the SayName funtion
            Console.ReadLine();  // This allows user to read the message sent via SayName()
        }
    }
}
