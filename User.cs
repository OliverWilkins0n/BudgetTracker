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
        private string Username { get; set; }
        private string Password;
        private Purchase purchases;
        private float Budget;

        
        public User(string Username, string Password) { 
            Random rnd = new Random();
            int userID  = rnd.Next(100000, 999999);
            this.ID = userID;
            this.Username = Username;
            this.Password = Password;
        }

        public string getUsername()
        {
            return Username;
        }
        public void setPassword(string NewPassword)
        {   
            Password = NewPassword;
        }

        public string getPassword() { return Password; }

        public override string ToString()
        {
            return "ID: " + ID + " Username: " + Username;
        }

    }

}
