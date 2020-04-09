using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM2
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "BANK OF ALL MAHOMIES 1989\u00a9";
            byte maxAttemptsToLogIn = 3;
            byte userAttempts = 0;
            decimal balance = 11250.50m;
            int pin = 1234;
            byte userAttempts2 = 0;
            int accountNumber = 12345;
            bool loggedInPin = false;
            bool loggedIn = false;

            do
            {
                #region Header
                Console.Clear();
                Console.WriteLine(@"                
    

                   .
                  .:.
                 .:::.
                .:::::.
            ***.:::::::.***
       *******.:::::::::.*******
     ********.:::::::::::.********
    ********.:::::::::::::.********                 Welcome to the Bank of All Mahomies
    *******.::::::'***`::::.*******
    ******.::::'*********`::.******
     ****.:::'*************`:.****
       *.::'*****************`.*
       .:'  ***************    .
      . ");
                #endregion
                Console.Write(@"                                       
                                              Enter your account number: ");

                userAttempts++;
                int userAccountNumber = int.Parse(Console.ReadLine());
                if (userAccountNumber == accountNumber)
                {
                    loggedIn = true;
                    do
                    {

                        #region Header
                        Console.Clear();
                        Console.WriteLine(@"                
    

                   .
                  .:.
                 .:::.
                .:::::.
            ***.:::::::.***
       *******.:::::::::.*******
     ********.:::::::::::.********
    ********.:::::::::::::.********                 Welcome to the Bank of All Mahomies
    *******.::::::'***`::::.*******
    ******.::::'*********`::.******
     ****.:::'*************`:.****
       *.::'*****************`.*
       .:'  ***************    .
      . ");
                        #endregion
                        Console.Write(@"                                    
                                        Please enter your pin associated with your account number: ");
                        userAttempts2++;

                        int userPin = int.Parse(Console.ReadLine());
                        if (userPin == pin)
                        {
                            loggedIn = false;
                            loggedInPin = true;
                            do
                            {



                                #region Header
                                Console.Clear();
                                Console.WriteLine(@"                
    

                   .
                  .:.
                 .:::.
                .:::::.
            ***.:::::::.***
       *******.:::::::::.*******
     ********.:::::::::::.********
    ********.:::::::::::::.********                 Welcome to the Bank of All Mahomies
    *******.::::::'***`::::.*******
    ******.::::'*********`::.******
     ****.:::'*************`:.****
       *.::'*****************`.*
       .:'  ***************    .
      . ");
                                #endregion
                                Console.Write(@"                            
                                    Welcome back how may we help you today?
                                                                            
                                                C)heck Balance                            
                                                D)eposit
                                                W)ithdrawal
                                                E)xit
                                                ");
                                ConsoleKey userChoice = Console.ReadKey(true).Key;
                                switch (userChoice)
                                {
                                    case ConsoleKey.C:
                                        #region Header
                                        Console.Clear();
                                        Console.WriteLine(@"                
    

                   .
                  .:.
                 .:::.
                .:::::.
            ***.:::::::.***
       *******.:::::::::.*******
     ********.:::::::::::.********
    ********.:::::::::::::.********                 Welcome to the Bank of All Mahomies
    *******.::::::'***`::::.*******
    ******.::::'*********`::.******
     ****.:::'*************`:.****
       *.::'*****************`.*
       .:'  ***************    .
      . ");
                                        #endregion
                                        Console.Write($@"                       
                            Your current balance is {balance:c}. Press any key to continue: ");
                                        Console.ReadKey();
                                        break;
                                    case ConsoleKey.D:
                                        DepositMethod(ref balance);
                                        break;
                                    case ConsoleKey.W:
                                        WithdrawalMethod(ref balance);
                                        break;
                                    case ConsoleKey.E:
                                        loggedInPin = false;
                                        userAttempts = 0;
                                        userAttempts2 = 0;
                                        break;
                                    default:
                                        //Blank returns user to make a valid choice 
                                        break;
                                }// end switch
                            } while (loggedInPin == true);
                        }//end if pin

                        else if (userAttempts2 == maxAttemptsToLogIn)
                        {
                            #region Header
                            Console.Clear();
                            Console.WriteLine(@"                
    

                   .
                  .:.
                 .:::.
                .:::::.
            ***.:::::::.***
       *******.:::::::::.*******
     ********.:::::::::::.********
    ********.:::::::::::::.********                 Welcome to the Bank of All Mahomies
    *******.::::::'***`::::.*******
    ******.::::'*********`::.******
     ****.:::'*************`:.****
       *.::'*****************`.*
       .:'  ***************    .
      . ");
                            #endregion
                            Console.Write(@"
                                    You have been kicked out due to entering 
                                            an incorrect pin too many times.

                                                Try again later.
    
                                            Press any key to continue.");
                            loggedIn = false;
                            Console.ReadKey();
                        }//end else if pin
                        else
                        {
                            #region Header
                            Console.Clear();
                            Console.WriteLine(@"                
    

                   .
                  .:.
                 .:::.
                .:::::.
            ***.:::::::.***
       *******.:::::::::.*******
     ********.:::::::::::.********
    ********.:::::::::::::.********                 Welcome to the Bank of All Mahomies
    *******.::::::'***`::::.*******
    ******.::::'*********`::.******
     ****.:::'*************`:.****
       *.::'*****************`.*
       .:'  ***************    .
      . ");
                            #endregion
                            Console.Write(@"                    
                            You have made {0} attempts out of 3 attempts to enter your pin. 

                                            Press any key to try again. ", userAttempts2);
                            Console.ReadKey();
                        }//end else pin

                    } while (userAttempts2 < maxAttemptsToLogIn && loggedIn == true);


                }//end if
                else if (userAttempts == maxAttemptsToLogIn)
                {
                    #region Header
                    Console.Clear();
                    Console.WriteLine(@"                
    

                   .
                  .:.
                 .:::.
                .:::::.
            ***.:::::::.***
       *******.:::::::::.*******
     ********.:::::::::::.********
    ********.:::::::::::::.********                 Welcome to the Bank of All Mahomies
    *******.::::::'***`::::.*******
    ******.::::'*********`::.******
     ****.:::'*************`:.****
       *.::'*****************`.*
       .:'  ***************    .
      . ");
                    #endregion
                    Console.Write(@"                        
                                You have been locked out due to too many failed attempts. 

                                            Press any key to continue.");
                    userAttempts = 0;
                    Console.ReadKey();
                    Console.Clear();
                }//end else if
                else
                {
                    #region Header
                    Console.Clear();
                    Console.WriteLine(@"                
    

                   .
                  .:.
                 .:::.
                .:::::.
            ***.:::::::.***
       *******.:::::::::.*******
     ********.:::::::::::.********
    ********.:::::::::::::.********                 Welcome to the Bank of All Mahomies
    *******.::::::'***`::::.*******
    ******.::::'*********`::.******
     ****.:::'*************`:.****
       *.::'*****************`.*
       .:'  ***************    .
      . ");
                    #endregion
                    Console.Write(@"                        
                            You have made {0} attempts out of 3 attempts on your account number.

                                            Press any key to try again. ", userAttempts);
                    Console.ReadKey();
                }//end else

            } while (loggedIn == false && userAttempts < maxAttemptsToLogIn);//do while loop                     
        }//end Main
        private static void DepositMethod(ref decimal balance)
        {
            ConsoleKey additionalDeposit;
            do
            {

                #region Header
                Console.Clear();
                Console.WriteLine(@"                
    

                   .
                  .:.
                 .:::.
                .:::::.
            ***.:::::::.***
       *******.:::::::::.*******
     ********.:::::::::::.********
    ********.:::::::::::::.********                 Welcome to the Bank of All Mahomies
    *******.::::::'***`::::.*******
    ******.::::'*********`::.******
     ****.:::'*************`:.****
       *.::'*****************`.*
       .:'  ***************    .
      . ");
                #endregion
                Console.WriteLine($@"                       Your current balance is {balance:c}.");
                Console.Write(@"                        What is the amount you would like to deposit? $");
                decimal deposit = decimal.Parse(Console.ReadLine());
                if (deposit < 0)
                {
                    deposit = 0;
                }
                Console.WriteLine($@"                       You are making a deposit of {deposit:c} which will bring " +
                    $"your balance to {balance + deposit:c}.");
                balance = balance + deposit;
                Console.Write(@"                                Would you like to make another deposit?(Y/N):");
                additionalDeposit = Console.ReadKey(true).Key;
            } while (additionalDeposit == ConsoleKey.Y);
        }//end 
        private static void WithdrawalMethod(ref decimal tryingNew)
        {
            ConsoleKey additionalWithdrawal;
            do
            {

                #region Header
                Console.Clear();
                Console.WriteLine(@"                
    

                   .
                  .:.
                 .:::.
                .:::::.
            ***.:::::::.***
       *******.:::::::::.*******
     ********.:::::::::::.********
    ********.:::::::::::::.********                 Welcome to the Bank of All Mahomies
    *******.::::::'***`::::.*******
    ******.::::'*********`::.******
     ****.:::'*************`:.****
       *.::'*****************`.*
       .:'  ***************    .
      . ");
                #endregion
                Console.WriteLine($@"                       Your current balance is {tryingNew:c}.");
                Console.Write(@"                        What is the amount you would like to withdrawal? $");
                decimal withdrawal = decimal.Parse(Console.ReadLine());
                if (withdrawal > tryingNew)
                {
                    withdrawal = tryingNew;
                }
                Console.WriteLine($@"                       You are making a withdrawal of {withdrawal:c} which will bring " +
                    $"your balance to {tryingNew - withdrawal:c}.");
                tryingNew = tryingNew - withdrawal;
                Console.Write(@"                                Would you like to make another withdrawal?(Y/N):");
                additionalWithdrawal = Console.ReadKey(true).Key;
            } while (additionalWithdrawal == ConsoleKey.Y);

        }

    }//end class
}//end namespace
