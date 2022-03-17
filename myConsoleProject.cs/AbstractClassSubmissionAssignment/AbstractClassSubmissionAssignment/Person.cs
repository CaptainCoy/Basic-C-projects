using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public abstract class Person  // Abstract class can not be instantiated, but can be inhereted
    {
        public string firstName { get; set; }  //  Person property
        public string lastName { get; set; }  // Another Person property
        public void SayName()  //  Function inside of the class Person 
        {
           
        }
    }
}
