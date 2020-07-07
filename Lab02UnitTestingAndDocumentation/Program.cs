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

                string userChoice = Console.ReadLine();

                switch(userChoice)
                {
                    case "1":
                        //ViewBalance();
                        break;
                    case "2":
                        Console.WriteLine("Please enter how much you want to withdraw.");                       
                        //Withdraw();
                        break;
                    case "3":
                        Console.WriteLine("Please enter how much you want to deposit.");
                        //Deposit();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using A.M.A.N.D.A. ATM services");
                        atmOn = false;
                        break;
                    default:
                        Console.WriteLine("Please press a number.");
                        break;
                }
            }
            
        }
    }
}
