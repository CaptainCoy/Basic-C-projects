using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { firstName = "Sample", lastName = "Student" };  // This instantiates the class Employee 
            emp.SayName(); //This calls the SayName() function from the class Employee
            Console.ReadLine();  // This allows the user to read message presented by SayName() function
        }
    }
}
