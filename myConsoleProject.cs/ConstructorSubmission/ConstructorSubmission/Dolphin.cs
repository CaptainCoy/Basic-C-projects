using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSubmission
{
    public class Dolphin  // This is creating the Dolphin class
    {
        public Dolphin() : this(0, "")
        {

        }
        public Dolphin(int intelect, string thanks)
        {
            int intellect = 2;
            thanks = "So long and thanks for all the fish...";
            Console.WriteLine(intellect + "\n\n\n\n\n\n\n\n\n" + thanks);
        }
           
    }
}
