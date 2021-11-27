using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Powers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coding Challenge: Powers!");

            /*
             * Using a For Loop, display teh powers of 2 from 1 to 50.
             * (2 to the 1st power through 2 to the 50th power). Use Long variable to store your results.
             * Example: 2 to the 4th power is 2x2x2x2.
             * 
             * Example Reference:
             * The Looping Classes _5Friday
             */

            long[] nmbr = { 2 };
            string power = "";
            for (long number = 2; number < 50; number++)
            {
                if (number != 0)
                {
                    power += "x2";
                }
            }//end for
          
        }//end svm
    }//end class
}//end namespace
