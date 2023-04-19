using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    class Purchase
    {
        public int ID { get; set; };
        public string ItemName { get; set; };
        public float Price { get; set; };
        public DateTime PurchaseDate { get; set; };

        public Purchase(string itemName, float price, DateTime purchaseDate) {
            Random rnd = new Random();
            int PurchaseID = rnd.Next(100000, 999999);
            this.ID = PurchaseID;
            this.ItemName = itemName;
            this.Price = price;
            this.PurchaseDate = purchaseDate;
        }
    }
}
