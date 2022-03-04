using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesList = { "Olive, ", "Brenda, ", "Debbie, ", "Sue, " };  // This is the array that we will be working with
            Console.WriteLine("Say something nice about my dogs...");  // This is the question that will kick off the program
            string answer = Console.ReadLine();  // User input

            for (int i = 0; i < namesList.Length; i++)
            {
                namesList[i] += answer;  //  This adds the user input to all of the strings in the array
                Console.WriteLine(namesList[i]);  // This prints all of the strings in the array
            }
            Console.ReadLine();  // This allow the user to read the strings

            //for (int i = 1; i > 0; i++)  // This will create an infinite loop. To fix this you would set "i" to = 0
            //{               
            //    Console.WriteLine("infinite");
            //}
            //Console.ReadLine();

            for (int i = 0; i < 7; i++)  // "i" is set to 0, so this will print every integers 1-6 because the second part is set to less than 7, "i++" 
                                         //  will print inters in ascending order because the ++ operator adds 1 to "i" every time it loops through until
                                         //  "i" is <7
            {
                
                Console.WriteLine(i);  // This prints the number for "i" as it loops
            }
            Console.ReadLine();  // This allows user to read each line

            for (int i = 0; i <= 7; i++)  // This is the same as the above loop only the middle operator is set to <= to 
                                          // instead of just < extending the printed list to 1-7 
            {

                Console.WriteLine(i);  //  Prints a number each loop until it reaches <=7
            }
            Console.ReadLine();  // Allows user to read line

            List<string> vip = new List<string>();  //  Starts a new sting list
            vip.Add("TRAVIS");
            vip.Add("OLIVE");
            vip.Add("SUSAN");
            vip.Add("MURPHEY");
            vip.Add("BRENDA");
            vip.Add("DEBBIE");  // These names all get added to the "vip" list

            Console.WriteLine("Who's on the list.");
            string input2 = Console.ReadLine().ToUpper();
            int num = 0;
            
            foreach (string i in vip)
            {
                if (i == input2)
                {
                    Console.WriteLine("We found " + input2 + " on the list");
                    num++;
                    break;
                }                         
               
            }
            if (num == 0)
            {
                Console.WriteLine("Nope, not on the list.");                
            }


            // This is a second option if you want to try this way

            //Console.WriteLine("Is your name on the list?");  // Asks the user for their name            
            //string user = Console.ReadLine();  // User input            
            //user = user.ToUpper(); // This changes user input to all caps
            //bool person = false;  // This sets the bool to false so the function can run

            //vip.Add("ALEX");
            //vip.Add("JENA");  // Adding two more down here to show you can

            //while (!person)  //  This will look for cases where person is true
            //{
            //    switch (user)
            //    {
            //        case "TRAVIS":
            //            Console.WriteLine("Congratulations " + user + " You're on the list!");  // List status confirmation message
            //            person = true; //  This sets the bool to true and confirms that they are indeed on the list
            //            Console.ReadLine();  // This allows the user to read the message
            //            break;  //  End case

            //        case "MURPHEY":
            //            Console.WriteLine("Congratulations " + user + " You're on the list!");  // List status confirmation message
            //            person = true; //  This sets the bool to true and confirms that they are indeed on the list
            //            Console.ReadLine();  // This allows the user to read the message
            //            break;  //  End case

            //        case "OLIVE":
            //            Console.WriteLine("Congratulations " + user + " You're on the list!");  // List status confirmation message
            //            person = true; //  This sets the bool to true and confirms that they are indeed on the list
            //            Console.ReadLine();  // This allows the user to read the message
            //            break;  //  End case

            //        case "BRENDA":
            //            Console.WriteLine("Congratulations " + user + " You're on the list!");  // List status confirmation message
            //            person = true; //  This sets the bool to true and confirms that they are indeed on the list
            //            Console.ReadLine();  // This allows the user to read the message
            //            break;  //  End case

            //        case "DEBBIE":
            //            Console.WriteLine("Congratulations " + user + " You're on the list!");  // List status confirmation message
            //            person = true; //  This sets the bool to true and confirms that they are indeed on the list
            //            Console.ReadLine();  // This allows the user to read the message
            //            break;  //  End case

            //        case "SUSAN":
            //            Console.WriteLine("Congratulations " + user + " You're on the list!");  // List status confirmation message
            //            person = true; //  This sets the bool to true and confirms that they are indeed on the list
            //            Console.ReadLine();  // This allows the user to read the message
            //            break;  //  End case

            //        case "ALEX":
            //            Console.WriteLine("Congratulations " + user + " You're on the list!");  // List status confirmation message
            //            person = true; //  This sets the bool to true and confirms that they are indeed on the list
            //            Console.ReadLine();  // This allows the user to read the message
            //            break;  //  End case

            //        case "JENA":  //  If you add list items in later make sure to add them in here too
            //            Console.WriteLine("Congratulations " + user + " You're on the list!");  // List status confirmation message
            //            person = true; //  This sets the bool to true and confirms that they are indeed on the list
            //            Console.ReadLine();  // This allows the user to read the message
            //            break;  //  End case

            //        default: // This is the answer for people that aren't on the list
            //            Console.WriteLine("Noooope not on the list.");
            //            Console.WriteLine("You may not proceed");
            //            Console.ReadLine();
            //            break;
            //    }

                List<string> stuff = new List<string>(); // Creating a new list that will contain the two identical strings for exercise five
                stuff.Add("dogs");
                stuff.Add("puppies");
                stuff.Add("doggos");
                stuff.Add("dogs");
                stuff.Add("pups");
                stuff.Add("puppers");                
                stuff.Add("poodles");
                stuff.Add("doodles");  // These strings are now all part of the stuff list

                Console.WriteLine("Enter an animal to see if it make a good pet.");
                string input1 = Console.ReadLine();
                int value1 = 0;                

                foreach (string i in stuff)
                {
                    if (i == input1)
                    {
                        Console.WriteLine("We found " + i + " in index" + value1);
                        value1++;
                    }
                    if (i != input1)
                    {
                        Console.WriteLine( i + " is not on the list" );
                        value1++;
                    }
                }

                Console.WriteLine("What animals make the best pets?");  // Question for the user
                string pets = Console.ReadLine();  // User input
                pets = pets.ToLower();  // Converts user input to lower case to make their answer fit the criteria easier
                bool  pet = false;  // Sets the bool to false so that the loop can search for true answers

                while (!pet)  // This is the loop funtion that runs while the boolean is still false
                {
                    switch (pets)  // This searches the list for the user's input
                    {
                        case "dogs":
                            Console.WriteLine("Correct " + pets + " make fine pets");
                            pet = true;  // Sets the bool to true, because that is a correct answer
                            Console.ReadLine(); // Allows user to read message
                            break; // This ends the loop

                        case "puppies":
                            Console.WriteLine("Correct " + pets + " make fine pets");
                            pet = true;  // Sets the bool to true, because that is a correct answer
                            Console.ReadLine(); // Allows user to read message
                            break; // This ends the loop

                        case "doggos":
                            Console.WriteLine("Correct " + pets + " make fine pets");
                            pet = true;  // Sets the bool to true, because that is a correct answer
                            Console.ReadLine(); // Allows user to read message
                            break; // This ends the loop

                        case "pups":
                            Console.WriteLine("Correct " + pets + " make fine pets");
                            pet = true;  // Sets the bool to true, because that is a correct answer
                            Console.ReadLine(); // Allows user to read message
                            break; // This ends the loop

                        case "puppers":
                            Console.WriteLine("Correct " + pets + " make fine pets");
                            pet = true;  // Sets the bool to true, because that is a correct answer
                            Console.ReadLine(); // Allows user to read message
                            break; // This ends the loop

                        case "poodles":
                            Console.WriteLine("Correct " + pets + " make fine pets");
                            pet = true;  // Sets the bool to true, because that is a correct answer
                            Console.ReadLine(); // Allows user to read message
                            break; // This ends the loop

                        case "doodles":
                            Console.WriteLine("Correct " + pets + " make fine pets");
                            pet = true;  // Sets the bool to true, because that is a correct answer
                            Console.ReadLine(); // Allows user to read message
                            break; // This ends the loop

                        default:  // This is the message for wrong answers
                            Console.WriteLine("Unless this is a term for dogs I don't know of, you are wrong.");
                            Console.ReadLine();
                            break;
                    }
                }

                List<string> other = new List<string>();
                
                foreach (string i in stuff)
                {
                    if (other.Contains(i))
                    {
                        Console.WriteLine(i + " Has already appeared on the list");
                    }

                    else
                    {
                        other.Add(i);
                        Console.WriteLine(i + " has been added to the list.");
                    }
                }
                Console.WriteLine(other);
                Console.ReadLine();
            }           


        
    }
}
