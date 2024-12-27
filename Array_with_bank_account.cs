using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_with_bank_account
{
    internal class Program
    {
        // Structure to store user account details
        struct UserAccount
        {
            public string Name;
            public int AccountNumber;
            public decimal Balance;
            static void Main(string[] args)
        {
            Console.Write("Enter the number of users: ");
            int numberOfUsers = int.Parse(Console.ReadLine());
            UserAccount[] users = new UserAccount[numberOfUsers];
            int userCount = 0;

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Display User Details");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Deposit Amount");
                Console.WriteLine("5. Withdraw Amount");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: // Add User
                        if (userCount < numberOfUsers)
                        {
                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Account Number: ");
                            int accountNumber = int.Parse(Console.ReadLine());
                            Console.Write("Enter Initial Balance: ");
                            decimal balance = decimal.Parse(Console.ReadLine());

                            users[userCount] = new UserAccount { Name = name, AccountNumber = accountNumber, Balance = balance };
                            userCount++;
                            Console.WriteLine("User added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("User limit reached.");
                        }
                        break;

                    case 2: // Display User Details
                        Console.Write("Enter Account Number to display details: ");
                        int displayAccountNumber = int.Parse(Console.ReadLine());
                        bool userFound = false;

                        foreach (var user in users)
                        {
                            if (user.AccountNumber == displayAccountNumber)
                            {
                                Console.WriteLine($"Name: {user.Name}, Account Number: {user.AccountNumber}, Balance: {user.Balance}");
                                userFound = true;
                                break;
                            }
                        }

                        if (!userFound) Console.WriteLine("User not found.");
                        break;

                    case 3: // Check Balance
                        Console.Write("Enter Account Number to check balance: ");
                        int checkAccountNumber = int.Parse(Console.ReadLine());
                        userFound = false;

                        foreach (var user in users)
                        {
                            if (user.AccountNumber == checkAccountNumber)
                            {
                                Console.WriteLine($"Balance: {user.Balance}");
                                userFound = true;
                                break;
                            }
                        }

                        if (!userFound) Console.WriteLine("User not found.");
                        break;

                    case 4: // Deposit Amount
                        Console.Write("Enter Account Number to deposit: ");
                        int depositAccountNumber = int.Parse(Console.ReadLine());
                        userFound = false;

                        for (int i = 0; i < users.Length; i++)
                        {
                            if (users[i].AccountNumber == depositAccountNumber)
                            {
                                Console.Write("Enter amount to deposit: ");
                                decimal amount = decimal.Parse(Console.ReadLine());
                                users[i].Balance += amount;
                                Console.WriteLine($"New Balance: {users[i].Balance}");
                                userFound = true;
                                break;
                            }
                        }

                        if (!userFound) Console.WriteLine("User not found.");
                        break;

                    case 5: // Withdraw Amount
                        Console.Write("Enter Account Number to withdraw: ");
                        int withdrawAccountNumber = int.Parse(Console.ReadLine());
                        userFound = false;

                        for (int i = 0; i < users.Length; i++)
                        {
                            if (users[i].AccountNumber == withdrawAccountNumber)
                            {
                                Console.Write("Enter amount to withdraw: ");
                                decimal amount = decimal.Parse(Console.ReadLine());

                                if (amount <= users[i].Balance)
                                {
                                    users[i].Balance -= amount;
                                    Console.WriteLine($"New Balance: {users[i].Balance}");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient balance.");
                                }
                                userFound = true;
                                break;
                            }
                        }

                        if (!userFound) Console.WriteLine("User not found.");
                        break;

                    case 6: // Exit
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }

}
    }

