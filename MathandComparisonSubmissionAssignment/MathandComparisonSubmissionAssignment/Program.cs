using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); // This displays the title of the program
            Console.ReadLine();  // This allows user to read previous line

            Console.WriteLine("Person 1\n");  // This shows that the user is entering info for person 1
            Console.WriteLine("Enter hourly rate."); // This is asking for the first input
            double rate1 = Convert.ToDouble(Console.ReadLine());  // This allows user to enter info
            Console.WriteLine("Enter hours worked per week.");  // Second input question
            double hours1 = Convert.ToDouble(Console.ReadLine());  // Second input answer
            double total1 = (rate1 * hours1) * 52;  // This multiplies the rate and hours, and then multiplies that by weeks in the year for an annual total
            Console.WriteLine("Person 1 worked " + hours1 + " hours at a rate of " + rate1 + " for a total of $" + total1 + " annually.");  // This line gives a recap of what was put in
            Console.ReadLine();

            Console.WriteLine("Person 2\n"); // This is the same as the block of code above just for user two
            Console.WriteLine("Enter hourly rate.");
            double rate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week.");
            double hours2 = Convert.ToDouble(Console.ReadLine());
            double total2 = (rate2 * hours2) * 52;
            Console.WriteLine("Person 2 worked " + hours2 + " hours at a rate of " + rate2 + " for a total of $" + total2 + " annually.");
            Console.ReadLine();

            Console.WriteLine("\n\nDoes person 1 make more than person 2?");  // This is the lin e for the final question
            bool answer = total1 > total2;  // This checks if user 1 makes more than user 2
            Console.WriteLine(answer);  // This gives a true or false answer to the question asked above
            Console.ReadLine();  // This allows the user to see the results
        }
    }
}
