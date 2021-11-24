using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login Warmup Exercise");

            /*
             * Class: Login.cs
             * 1. Ask the user for their username
             * 2. If it matches your one hard-coded, correct username, tell the user that they have
             * access. If not, tell the user that they have been denied access.
             * 3. Make sure the usernames (hard-coded & user input) are case insensitive (uppercase
             * or lowercase).
             * ADDITIONAL FUNCTIONALITY: After the above default functionality is completed:
             * 4. Encase the username functionality in a loop that allows the user to make another
             * attempt if the previous attempt was unsuccessful.
             * 5. Extend the loop functionality to deny access to the user if they enter the wrong 
             * username 3 times.
             * 6.Extend updated username functionality to ask for a password if the user entered the 
             * correct username. Deny access if the password is entered incorrectly 3 times. (Note:3
             * attempts username, if the correct username is entered, give 3 attempts for the 
             * correct password.)
             * 
             * Example References:
             * InputLab.cs in _4Thursday
             * BranchingIf.cs or BranchingSwitch _4Thursday
             * LogicComparisons.cs in _3Wednesday
             * Additional Funcionality References:
             * LoopingFor.cs, LoopingWhile.cs, LoopingDoWhile.cs _5Friday
             */

            const string username = "Homer";
            const string password = "Simpson";
            for (int attempts = 0; attempts < 3; ++attempts)
            {
                Console.WriteLine("Please Enter Username: ");
                string userResp = Console.ReadLine();
                if (userResp == username)
                {
                    Console.WriteLine("Access Granted\n");
                    

                    for (int passwordAttempts = 0; passwordAttempts < 3; ++passwordAttempts)
                    {
                        Console.WriteLine("Please Enter Password: ");
                        string userResp2 = Console.ReadLine();
                        if (userResp2 != password)
                        {
                            Console.WriteLine("Access Denied");
                            
                        }//end if
                        else
                        {
                            Console.WriteLine("Access Granted");
                            return;
                        }//end else
                    }//end for
                }//end if
                else
                {
                    Console.WriteLine("Access Denied");
                    
                }//end else
            }//end for           

        }//end svm
    }//end class
}//end namespace
