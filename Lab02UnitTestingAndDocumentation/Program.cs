using System;

namespace Lab02UnitTestingAndDocumentation
{
    public class Program
    {
        static public decimal Balance = 100;

        /// <summary>
        /// This is the main insertion of the app
        /// It runs the UserInterface Methos
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            UserInterface();
        }

        /// <summary>
        /// This is the main hub of the application
        /// This is will direct the rest of the application
        /// It also holds all the WriteLines and ReadLines for the application
        /// It a while loop until the user decides to logout.
        /// </summary>
        public static void UserInterface()
        {
            bool atmOn = true;

            while (atmOn)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Check your Balance");
                Console.WriteLine("2. Make a Withdraw?");
                Console.WriteLine("3. Make a Deposit?");
                Console.WriteLine("4. Logout?");
                Console.WriteLine();

                string userChoice = Console.ReadLine();

                Console.WriteLine();

                try
                {
                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine($"Your balance is: ${String.Format("{0:0.00}", ViewBalance())}");
                            Console.WriteLine();
                            break;
                        case "2":
                            Console.WriteLine("Please enter how much you want to withdraw.");
                            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                            Balance = Withdraw(withdrawAmount, Balance);
                            Console.WriteLine($"Your balance is: ${String.Format("{0:0.00}", ViewBalance())}");
                            Console.WriteLine();
                            break;
                        case "3":
                            Console.WriteLine("Please enter how much you want to deposit.");
                            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                            Balance = Deposit(depositAmount, Balance);
                            Console.WriteLine($"Your balance is: ${String.Format("{0:0.00}", ViewBalance())}");
                            Console.WriteLine();
                            break;
                        case "4":
                            Console.WriteLine("Thank you for using A.M.A.N.D.A. ATM services");
                            Console.WriteLine();
                            atmOn = false;
                            break;
                        default:
                            Console.WriteLine("Please press a valid number.");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number");
                }
            }

        }

        /// <summary>
        /// This method allows the user to check their balance. It just returns the global 
        /// Balance variable back to the caller.
        /// </summary>
        /// <returns>A decimal type</returns>
        public static decimal ViewBalance()
        {
            return Balance;
        }

        /// <summary>
        /// This allows for a user defined amount to be withdrawn from the account
        /// This method will not accept a negative
        /// Nor will it allow the user to overdraft
        /// </summary>
        /// <param name="withdrawAmount">The User inputed amount</param>
        /// <param name="inputBalance">The Balance global variable</param>
        /// <returns>A decimal which the UserInterface method to update the Balance variable</returns>
        public static decimal Withdraw(decimal withdrawAmount, decimal inputBalance)
        {
            if (withdrawAmount < 0)
            {
                Console.WriteLine("I am sorry you can not withdraw a negative amount");
                return inputBalance;
            }
            else
            {
                decimal newBalance = inputBalance - withdrawAmount;
                if (newBalance < 0)
                {
                    Console.WriteLine("I am sorry you can not perform an overdraft.");
                    return inputBalance;
                }
                else
                {
                    return newBalance;
                }
            }
        }

        /// <summary>
        /// This allows for a user defined amount to be depoited into the account
        /// This method will not accept a negative       
        /// </summary>
        /// <param name="depositAmount">The user inputed amount</param>
        /// <param name="inputBalance">The Balance global variable</param>
        /// <returns>A decimal which the UserInterface method to update the Balance variable</returns>
        public static decimal Deposit(decimal depositAmount, decimal inputBalance)
        {
            if (depositAmount < 0)
            {
                Console.WriteLine("I am sorry you can not deposit a negative amount");
                return inputBalance;
            }
            else
            {
                decimal newBalance = inputBalance + depositAmount;

                return newBalance;
            }
        }
    }
}
