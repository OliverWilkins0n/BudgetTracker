using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    internal class Menu
    {
        public int WelcomeMenu()
        {
            App app = new App();
            Console.WriteLine("===Main Menu===");
            Console.WriteLine("1 - Create Account");
            Console.WriteLine("2 - Login");
            Console.WriteLine("3 - Quit");
            string answer = Console.ReadLine();
            Console.Write(answer);

            switch (answer) {
                case "1": {
                        return 1;
                }
                case "2":
                    {
                        return 2;
                    }
                case "3":
                    {
                        return 3;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Response");
                        return WelcomeMenu();
                    }
            }
        }
        public Tuple<string, string> CreateAccountMenu()
        {
            string UserName;
            string Password;
            do
            {
                try
                {
                    Console.Write("Enter Username: ");
                    UserName = Console.ReadLine().Trim();
                    Console.Write("Enter Password: ");
                    Password = Console.ReadLine().Trim();

                    if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
                    {
                        Console.WriteLine("Username and password cannot be empty. Please try again.");
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"An error occurred while reading the input: {ex.Message}");
                    UserName = null;
                    Password = null;
                }
            } while (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password));
            return Tuple.Create(UserName, Password);
        }


    }
}
