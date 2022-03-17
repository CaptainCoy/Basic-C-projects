using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmissionAssignment
{
    public class Employee : Person  //  This allows class Employee to inherit all attributes from class Person
    {
        public int ID { get; set; }  // This is a property specific to Employee class
    }
}
