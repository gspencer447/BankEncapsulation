namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank.BankAccount account1 = new Bank.BankAccount();

            Console.WriteLine("Welcome! To access your account, please choose a menu action.");

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Account Balance");
                Console.WriteLine("4. Exit");

                string selection = Console.ReadLine();

                if (selection == "1")
                {
                    Console.WriteLine("Please enter amount for deposit.");
                    if (double.TryParse(Console.ReadLine(), out double depositAmount))
                    { 
                        if (depositAmount >= 0)
                        {
                        account1.Deposit(depositAmount);
                        Console.WriteLine($"Your deposit of {depositAmount} dollars was successful");
                        }
                        else
                        {
                            Console.WriteLine("Cannot deposit a negative amount. Please enter a valid amount.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input invalid. Please try again.");
                    }
                }
                else if (selection == "2")
                {
                    Console.Write("Enter the withdrawal amount: ");
                    if (double.TryParse(Console.ReadLine(), out double withdrawalAmount))
                    {
                        double amountTaken = account1.Withdraw(withdrawalAmount);
                        if (amountTaken > 0)
                        {
                            Console.WriteLine($"Withdrawal of {amountTaken} dollars successful.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for withdrawal amount.");
                    }
                }
                else if (selection == "3")
                    {
                        double accountBalance = account1.GetBalance();
                        Console.WriteLine($"Your account balance is {accountBalance} dollars.");
                    }
                else if (selection == "4")
                    {
                        Console.WriteLine("Thank you for banking with us!");
                        Environment.Exit(0);
                    }
                else 
                    {
                        Console.WriteLine("Please input a valid selection");
                    }
                }
            }
        }
    }
