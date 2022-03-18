using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public class Employee : Person, IQuittable  // Class employee can be instantiated and inherits attributes from class Person and interface IQuittable
    {
        public int ID { get; set; }  // Property specific to class Employee

        public static bool operator == (Employee employee, Employee employee1)
        {
            if (employee.ID == employee1.ID)
                return true;
            else
                return false;
        }
        public static bool operator != (Employee employee, Employee employee1)
        {
            if (employee.ID != employee1.ID)
                return false;
            else
                return true;
        }

        public new void SayName()  // Takes function inherited from class Person
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);  // Message to user
        }        
        public void Quit()  // This calls the Quit function from IQuittable
        {
            Console.WriteLine("I quit!");  // Quit message
        }
    }
}
