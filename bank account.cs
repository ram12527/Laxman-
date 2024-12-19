namespace BANK_ACCOUNT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize account details
            string accountNumber = "";
            string accountHolderName = "";
            decimal balance = 0;

            // Main menu
            while (true)
            {
                Console.WriteLine("Bank Account System");
                Console.WriteLine("1. Enter User Details");
                Console.WriteLine("2. Display User Details");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Add Amount");
                Console.WriteLine("5. Withdrawal");
                Console.WriteLine("6. Exit");

                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        EnterUserDetails(ref accountNumber, ref accountHolderName, ref balance);
                        break;
                    case 2:
                        DisplayUserDetails(accountNumber, accountHolderName, balance);
                        break;
                    case 3:
                        CheckBalance(balance);
                        break;
                    case 4:
                        AddAmount(ref balance);
                        break;
                    case 5:
                        Withdrawal(ref balance);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }

        // Method to enter user details
        static void EnterUserDetails(ref string accountNumber, ref string accountHolderName, ref decimal balance)
        {
            Console.Write("Enter account number: ");
            accountNumber = Console.ReadLine();

            Console.Write("Enter account holder name: ");
            accountHolderName = Console.ReadLine();

            Console.Write("Enter initial balance: ");
            balance = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("User details entered successfully.");
        }

        // Method to display user details
        static void DisplayUserDetails(string accountNumber, string accountHolderName, decimal balance)
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder Name: " + accountHolderName);
            Console.WriteLine("Available Balance: " + balance);
        }

        // Method to check balance
        static void CheckBalance(decimal balance)
        {
            Console.WriteLine("Available Balance: " + balance);
        }

        // Method to add amount
        static void AddAmount(ref decimal balance)
        {
            Console.Write("Enter amount to add: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            balance += amount;
            Console.WriteLine("Amount added successfully.");
        }

        // Method to withdraw amount
        static void Withdrawal(ref decimal balance)
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
                Console.WriteLine("Amount withdrawn successfully.");
            }
        }
    }
    }

