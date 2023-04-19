using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    class User
    {
        public int ID { get; set; }
        private string UserName { get; set; }
        private string Password;
        private float Budget;

        
        public User(string UserName, string Password) { 
            Random rnd = new Random();
            int userID  = rnd.Next(100000, 999999);
            this.ID = userID;
            this.UserName = UserName;
            this.Password = Password;
        }

        public string getUsername(string username)
        {
            return username;
        }
        public void setPassword(string NewPassword)
        {   
            Password = NewPassword;
        }

        public override string ToString()
        {
            return "ID: " + ID + " Username: " + UserName;
        }
    }

}
