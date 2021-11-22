using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MadLibs Homework!");
            /*
             * Create a "mad lib" that asks the user for varios pieced of information.
             * Store the information as Strings. Once the information has been collected,
             * output a story using the stored information. 
             * Ref: InputLab.CS class in _4Thursday - receiving input
             */

            Console.WriteLine("Hello! Lets do a Mad Lib!");

            Console.Write("Give me a nound: ");
            string noun = Console.ReadLine();

            Console.Write("Give me a city: ");
            string city = Console.ReadLine();

            Console.Write("Give me a number: ");
            string number = Console.ReadLine();

            Console.Write("Give me a time period: ");
            string timePeriod = Console.ReadLine();

            Console.Write("Give me an adjective: ");
            string adjective = Console.ReadLine();

            Console.Write("Give me another adjective: ");
            string adjective2 = Console.ReadLine();

            Console.Write("Give me a person's name: ");
            string personsName = Console.ReadLine();

            Console.Write("Give me a type of clothing: ");
            string typeOfClothing = Console.ReadLine();

            Console.Write("Lastly, give me a color: ");
            string color = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"It is a little known fact that {noun}s have been watching {city} for {number} {timePeriod}." +
            $"\n\n Only the {adjective} people believed that it was just a matter of time before {noun}s invaded the {adjective2} city of {city}." +

            $"\n\n{personsName}, who was a {adjective} person tried to warn the people, telling them their best defense was to hang {typeOfClothing}s" +
            $" from the trees and {color} shoes on every door knob." +

            $"\n\nUnfortunately no one believed {personsName} and when {noun}s attacked {city}, only the {adjective} people survived.");
        }//end svm
    }//end class
}//end namespace
