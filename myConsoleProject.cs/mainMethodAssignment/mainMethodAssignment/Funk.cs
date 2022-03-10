using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethodAssignment
{
    public class Funk // Allows funtion to be used on Program page
    {
        public double Mult(int numNum)  // Setting the function 
        {
            return numNum * 1000000;  // What we want the function to do is multiply numNum by a million
        }
        public int Mult(int numNum, decimal num1)
        {
            int returnFunk = Convert.ToInt32(num1);
            return numNum * returnFunk;
        }
        public int Mult(string theFunk)
        {
            int returnFunk2 = Convert.ToInt32(theFunk);
            return 42 * returnFunk2; 
        }

    }
}
