using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Temp_Converter2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");
            /*
             * 1. Write a program that asks the user for a temperature in Celsius and converts it to
             * Fahrenheit. The conversion is done by multiplying the Celsius by 9/5 and then
             * adding 32. (fah = cel * (9.0/5.0) + 32). When testing your program, use 100 degrees
             * Celsius as an example - the result should be 212 degrees Fahrenheit.
             * 
             * 2. Next write additional functionality that asks the user for a Fahrenheit 
             * temperature and converts it to Celsius. The conversion is done by taking the 
             * Fahrenheit temperature, subtracting 32, then dividing by 9/5. (cel = (fah - 32) / (9.0/5.0)
             * 
             * 3. Then, build out a menu that allows the user to choose whether they wish to 
             * convert Celius to Fahrenheit or Fahrenheit to Celsius. Remember, you'll wan to
             * capture the user's input, and then utilize the two pieces of functionality you built
             * (steps a, b) to show the result
             * 
             * 4. Lastly, extend the functionality to ask the user if they have another conversion once
             * you have shown them their initial result. Reload the menu if they choose yes.
             * 
             * Ex Reference:
             * InputLab.cs class in _4Thursday - receiving input
             * LoopingDoWhile.cs class in _5Friday - repeat code based on user deicision
             */

            Console.Write("Please give me a temperature in Celsius: ");
            int fahrenheit = int.Parse(Console.ReadLine());
            Console.WriteLine("That temperature in Fahrenheit is: " + (fahrenheit * (9.0 / 5.0) + 32));

            Console.Write("Please give me a temperaure in Fahrenheit: ");
            int celsius = int.Parse(Console.ReadLine());
            Console.WriteLine("That temperature in Celsius is: " + (celsius - 32 / (9.0 / 5.0)));


            bool repeat = true;
            do
            {


                Console.Clear();
                Console.WriteLine("Welcome to Temperature Conversion!");
                Console.WriteLine("Please give me a temperature: ");
                int temperature = int.Parse(Console.ReadLine());
                Console.WriteLine(@" How would you like to convert this? 
1) Celsius to Fahrenheit
2) Fahrenheit to Celsius
");
                string userChoice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (userChoice)
                {
                    case "1":
                    case "f":
                    case "fahrenheit":
                        Console.WriteLine("That temperature in Fahrenheit is: " + (temperature * (9.0 / 5.0) + 32) + "\u00B0F");
                        Console.WriteLine("Do you have more temperatures you want to convert?: Y/N");
                        string userAnswer = Console.ReadLine().ToLower();
                        if (userAnswer == "y")
                        {
                            continue;
                        }
                        else if (userAnswer == "n")
                        {
                            break;
                        }
                        break;


                    case "2":
                    case "c":
                    case "celsius":
                        Console.WriteLine("That temperature in Celsius is: " + (celsius - 32 / (9.0 / 5.0)) + "\u00B0C");
                        Console.WriteLine("Do you have more temperatures you want to convert?: Y/N");
                        string userAnswer2 = Console.ReadLine().ToLower();
                        if (userAnswer2 == "y")
                        {
                            continue;
                        }
                        else if (userAnswer2 == "n")
                        {
                            break;
                        }
                        break;

                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }//end switch
                break;

            } while (repeat);
            Console.WriteLine("Thank you for converting with us!");

        }//end svm
    }//end class
}//end namespace
