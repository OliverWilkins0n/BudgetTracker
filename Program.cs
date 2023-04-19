using System.Runtime.CompilerServices;

namespace BudgetTracker
{
    class App {
        private List<User> users = new List<User>();
        public static void Main(string[] args)
        {
            App app = new App();
            Menu menu = new Menu();
            int WelcomeAnswer = menu.WelcomeMenu();
            
            if (WelcomeAnswer == 1) //Create Account
            {
                Tuple<string, string> accountInfo = menu.CreateAccountMenu();
                app.CreateAccount(accountInfo.Item1, accountInfo.Item2);
                WelcomeAnswer = menu.WelcomeMenu();
            }
        }


        public void CreateAccount(string UserName, string Password) {
                users.Add(new User(UserName, Password));
                Console.WriteLine("User " + UserName + " has been created!");
       
        }
    }
}




