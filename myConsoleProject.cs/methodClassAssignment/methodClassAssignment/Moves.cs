using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodClassAssignment
{
    class Moves
    {
        public void again(int pThree, int pFour)  // This takes in the variables from Program user input
        {
            int maths = pThree + 100;  // This operation happens inside the program and doesn't display to the user
            Console.WriteLine(pFour);  // This writes out the second user input
        }
        public int Add(int pTwo, int pOne)  // This takes the variables from the Program
        {
            return pTwo + pOne;  // This adds the two variables together
        }
    }
}
