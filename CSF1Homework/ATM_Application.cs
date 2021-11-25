using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM_Application
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM APPLICATION");
            /*
             * 1. Ask the user to enter an account number for their account
             *      a. Continue to ask the user for their account number until they get it right
             *      (the correct account number will be hard coded in your code. See the Login secion
             *      an example). Optionally, consider locking them out after a certain number of 
             *      failed attempts.
             *      
             * 2. Once they get the correct account number, ask them for a pin number (you can use 
             *    the additional Login functionality as a reference). Just as you did for their account
             *    number, continue to prompt the user for their pin  until they get it correct. (The 
             *    correct value will be hard coded just as it was for the account number).
             *    
             * 3. Once the user has succesfully given their account and pin numbers, prompt the 
             *    user with a menu and ask them if they want to do a deposit, a withdrawal, or exit the
             *    application.
             *    
             * 4. If they choose to do a deposit, ask them for the amount to deposit, and display the 
             *    amount deposited.
             *      a. Ex: "$500.00 has been deposited into account number (account #)".
             *      
             * 5. If they choose to withdraw money, ask them for the amount to withdraw and display 
             *    the amount beng withdrawn.
             *      a. Ex: "$500.00 has been withdrawn from account number (account #)."
             *      
             * 6. After each transaction (deposit or withdrawal) ask the user if they want to do another
             *    deposit /withdrawal, or exit the application.
             *    
             * 7. When the user exits the application, thank them for their business
             * 
             * ADDITIONAL OPTIONAL FEATURES
             * 
             *  Keep a running total of the account balance, assuming that the account starts at $0.
             *  
             *  Everytime the user makes a deposit to - or withdraw from - the account, the 
             *  balance should be updated and displayed.
             *  
             *  Add a feature for the user to make balance request that will display their current
             *  balance (without needing to make a deposit or withdrawal).
             *  
             *  Example References:
             *  InputLab.cs in _4Thursday
             *  BranchingIf.cs or BranchingSwitch.cs _4Thursday
             *  LogicComparison.cs - case sensitivity
             */

            
            const int accountNumbr = 12345;
            const int pinNumbr = 54321;
            for (int attempts = 0; attempts < 3; ++attempts)
            {
                Console.WriteLine("Please Enter Account Number: ");
                int userResp = int.Parse(Console.ReadLine());
                if (userResp == accountNumbr)
                {
                    Console.WriteLine("Access Granted\n");


                    for (int pinAttempts = 0; pinAttempts < 3; ++pinAttempts)
                    {
                        Console.WriteLine("Please Enter PIN: ");
                        int userResp2 = int.Parse(Console.ReadLine());
                        if (userResp2 == pinNumbr)
                        {
                            Console.Clear();
                            Console.WriteLine("Access Granted");

                            decimal balance = 500m;
                            bool repeat = true;
                            do
                            {
                                Console.WriteLine(@"What would you like to do today?: 
1) Deposit
2) Withdrawal
3) Balance Request
4) Exit
");
                                string userResponse = Console.ReadLine().ToLower();
                                Console.Clear();
                                switch (userResponse)
                                {
                                    case "1":
                                    case "d":
                                    case "deposit":
                                        Console.Clear();
                                        Console.WriteLine("How much would you like to Deposit?: ");
                                        decimal depAmt = decimal.Parse(Console.ReadLine());
                                        Console.WriteLine($"{depAmt:c} has been deposited into account number {accountNumbr}. Current balance is now {depAmt += balance:c}");
                                        Console.WriteLine("Would you like to make another transaction?: Y/N");
                                        string userAnswer = Console.ReadLine().ToLower();
                                        if (userAnswer == "y")
                                        {
                                            continue;
                                        }
                                        else if (userAnswer == "n")
                                        {
                                            Console.WriteLine("Thank you for banking with us!");
                                            return;
                                        }
                                        break;

                                    case "2":
                                    case "w":
                                    case "withdrawal":
                                        Console.Clear();
                                        Console.WriteLine("How much would you like to withdraw?: ");
                                        decimal withdAmt = decimal.Parse(Console.ReadLine());
                                        if (withdAmt > balance)
                                        {
                                            Console.WriteLine("Sorry, Insufficient Funds.");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{withdAmt:c} has been withdrawn from account number {accountNumbr}. Current balance is now {withdAmt -= balance:c}");
                                        }
                                        Console.WriteLine("\nWould you like to make another transaction?: Y/N");
                                        string userAnswer2 = Console.ReadLine().ToLower();
                                        if (userAnswer2 == "y")
                                        {
                                            continue;
                                        }
                                        else if (userAnswer2 == "n")
                                        {
                                            Console.WriteLine("Thank you for banking with us!");
                                            return;
                                        }
                                        break;

                                    case "3":
                                    case "b":
                                    case "balance":
                                    case "balance request":
                                        Console.Clear();
                                        Console.WriteLine($"Your current balance is {balance:c}");
                                        Console.WriteLine("Would you like to make another transaction?: Y/N");
                                        string userAnswer3 = Console.ReadLine().ToLower();
                                        if (userAnswer3 == "y")
                                        {
                                            continue;
                                        }
                                        else if (userAnswer3 == "n")
                                        {
                                            Console.WriteLine("Thank you for banking with us!");
                                            return;
                                        }
                                        break;

                                    case "4":
                                    case "e":
                                    case "exit":
                                        Console.Clear();
                                        Console.WriteLine("Thank You for Banking with us.");
                                        repeat = false;
                                        return;
                                    default:
                                        break;
                                }//end switch

                            } while (repeat);

                        }//end if
                        else
                        {
                            Console.WriteLine("Access Denied");
                            
                        }//end else
                    }//end for
                    Console.WriteLine("\n\nYour Account has been locked.");
                    return;
                }//end if
                else
                {
                    Console.WriteLine("Access Denied");

                }//end else
            }//end for           
            Console.WriteLine("Thank you for banking with us!");
        }//end svm
    }//end class
}//end name space
