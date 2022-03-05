using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try  //  This contains the function that we want the program to run
            {
                Console.WriteLine("Pick a number.");  // This message asks the user to input a number
                int numberOne = Convert.ToInt32(Console.ReadLine());  // This takes user input
                Console.WriteLine("Pick a second number.");  // This asks for the number that the first number will be divided by
                int numberTwo = Convert.ToInt32(Console.ReadLine());  // This takes user input                
                int numberThree = numberOne / numberTwo;  // This divides numberOne by numberTwo
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);  // This displays a message explaining what the program just did
                Console.ReadLine();  // This displays the message to the user
            }

            //  This comes in to play if the user does something that the program doesn't like

            catch(FormatException ex)  // This checks to see if the user input a number and not a string or another data type
            {
                Console.WriteLine(ex.Message);  // This displays the error message to the user
                return;  // This ends the program
            }
            catch (DivideByZeroException)  //  This doesn't allow for the first number to be divided by zero
            {
                Console.WriteLine("Don't use zer0");  // This displays to the user that they can't divide by zero
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally  //  This is the last thing that the function will do
            {
                Console.WriteLine("That's all folks...");  // This is the last message
                Console.ReadLine();  // This let's the user read the message
            }           
        }
    }
}
