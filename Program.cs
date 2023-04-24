using System.Runtime.CompilerServices;

namespace BudgetTracker
{
    class App {
        //private List<User> users = new List<User>();
        Dictionary<string, User> users = new Dictionary<string, User>();
        string currentMenu = "welcome";
        Menu menu = new Menu();
        User user = null;
        Boolean LoggedIn = false;

        public static void Main(string[] args)
        {
            App app = new App();
            int WelcomeAnswer = app.menu.WelcomeMenu();
            app.Setup(app, WelcomeAnswer);

        }

        public void Setup(App app, int WelcomeAnswer)
        {
            while (LoggedIn == false)
            {
                if (WelcomeAnswer == 1) //Create Account
                {
                    Tuple<string, string> accountInfo = menu.AccountMenu();
                    User newUser = new User(accountInfo.Item1, accountInfo.Item2);
                    //app.CreateAccount(accountInfo.Item1, accountInfo.Item2);
                    app.CreateAccount(newUser);
                    WelcomeAnswer = menu.WelcomeMenu();
                }
                else if (WelcomeAnswer == 2) //Login
                {
                    while (LoggedIn == false)
                    {
                        Tuple<string, string> LoginInfo = menu.AccountMenu();
                        if (users.TryGetValue(LoginInfo.Item1, out User user) && user.getPassword() == LoginInfo.Item2)
                        {
                            LoggedIn = true;
                            Console.WriteLine("Logged In");
                            Console.WriteLine("Welcome " + user.getUsername());
                            Console.ReadLine();
                        }
                    } // User is now logged in
                    /* Display budget left
                     * 1. Update Budget
                     * 2. View Purchases
                     * 3. Add Purchase
                     * 4. Remove Purchase
                    */
                }
            }
        }



       /* public void CreateAccount(string UserName, string Password) {
                users.Add(new User(UserName, Password));
                Console.WriteLine("User " + UserName + " has been created!");      
        } */
        public void CreateAccount(User newUser)
        {
            string username = newUser.getUsername();
            users.Add(username, newUser);
        }
    }
}




