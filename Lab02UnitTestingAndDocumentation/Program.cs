using System;

namespace Lab02UnitTestingAndDocumentation
{
    public class Program
    {
        static public decimal Balance = 0;

        static void Main(string[] args)
        {
            UserInterface();
        }

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
                            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                            //Withdraw(withdrawAmount);
                            Console.WriteLine();
                            break;
                        case "3":
                            Console.WriteLine("Please enter how much you want to deposit.");
                            int depositAmount = Convert.ToInt32(Console.ReadLine());
                            //Deposit(depositAmount);
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

        public static decimal ViewBalance()
        {
            return Balance;
        }


    }
}
