using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() // This creates a list that will employees will be added to
            {
                new Employee { fName = "Alex", lName = "Coy", iD = 42},  // Adding employees to the list employees
                new Employee { fName = "Jena", lName = "Coy", iD = 13},
                new Employee { fName = "Joe", lName = "Rogan", iD = 3},
                new Employee { fName = "Susan", lName = "Marshmallow", iD = 1},
                new Employee { fName = "Debbie", lName = "Doo", iD = 15},
                new Employee { fName = "Joe", lName = "Johnson", iD = 2},
                new Employee { fName = "Bill", lName = "Burr", iD = 4},
                new Employee { fName = "Brenda", lName = "Coffee", iD = 11},
                new Employee { fName = "Larry", lName = "Bird", iD = 33},
                new Employee { fName = "Joe", lName = "Diaz", iD = 44}
            };

            List<Employee> joes = new List<Employee>();  // This creates a new list

            foreach (Employee employee in employees)  // In the parentheses is the data the program is looking at
            {                
                if (employee.fName == "Joe")  // This is the condition the program is looking for
                {
                    joes.Add(employee);  // If the persons first name is Joe then they are added to the list
                    Console.WriteLine("Employee " + " " + employee.iD + " was added");  // This informs the user that employees that fit the condition were added to the list and provides their ID number
                }
                                
            }
            

            List<Employee> joes2 = employees.Where(x => x.fName == "Joe").ToList();  // This is a Lambda expression that does the same task as above
            Console.WriteLine("\n\nEmployees named Joe:\n");  // Message to user
            joes2.ForEach(x => Console.WriteLine(x.iD + " " + x.fName + " " + x.lName));  // Instead of giving the ID number this Time their names are presented
            

            List<Employee> identifiers = employees.Where(x => x.iD > 5).ToList();  // This Lambda statement looks through the ID nunmbers and adds those greater than 5 to the list
            Console.WriteLine("\n\nID numbers greater than 5:\n");  // Message to user
            identifiers.ForEach(x => Console.WriteLine(x.iD +" " + x.lName));  // This lists the ID numbers and the last name of the employees on the list
            Console.ReadLine();  // This allows the user to read the line
             

        }
    }
}
