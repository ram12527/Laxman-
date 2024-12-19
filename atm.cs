using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_ACCOUNT
{
    internal class ATM_APP
    {
        static void Main(string[] args)
        {
            // Initialize account details
            string accountNumber = "1234567890";
            string pin = "1234";
            decimal balance = 5000;

            // Main menu
            while (true)
            {
                Console.WriteLine("ATM Application");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Exit");

                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Login(accountNumber, pin, ref balance);
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }

        // Method to login
        static void Login(string accountNumber, string pin, ref decimal balance)
        {
            Console.Write("Enter account number: ");
            string inputAccountNumber = Console.ReadLine();

            Console.Write("Enter PIN: ");
            string inputPin = Console.ReadLine();

            if (inputAccountNumber == accountNumber && inputPin == pin)
            {
                Console.WriteLine("Login successful.");
                MainMenu(ref balance);
            }
            else
            {
                Console.WriteLine("Invalid account number or PIN.");
            }
        }

        // Method to display main menu
        static void MainMenu(ref decimal balance)
        {
            while (true)
            {
                Console.WriteLine("ATM Application");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Withdraw Cash");
                Console.WriteLine("3. Deposit Cash");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        CheckBalance(balance);
                        break;
                    case 2:
                        WithdrawCash(ref balance);
                        break;
                    case 3:
                        DepositCash(ref balance);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }

        // Method to check balance
        static void CheckBalance(decimal balance)
        {
            Console.WriteLine($"Available Balance: {balance}");
        }

        // Method to withdraw cash
        static void WithdrawCash(ref decimal balance)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Withdrawal successful.");
                Console.WriteLine($"Available Balance: {balance}");
            }
        }

        // Method to deposit cash
        static void DepositCash(ref decimal balance)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            balance += amount;
            Console.WriteLine("Deposit successful.");
            Console.WriteLine($"Available Balance: {balance}");
        }
    }
}
        