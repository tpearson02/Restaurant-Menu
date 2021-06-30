using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class MenuItem
       
        // Fields
    {
        public double ItemPrice { get; set; }
        public string ItemDescription { get; set; }
        public string ItemCategory { get; set; }
        public DateTime itemDateTime { get; }
       
      
        // Constructor
        public MenuItem(double price, string description, string category)
        {
            this.ItemPrice = price;
            this.ItemDescription = description;
            this.ItemCategory = category;
            this.itemDateTime = DateTime.Today;
        }

        internal static void PrintItems()
        {
            throw new NotImplementedException();
        }
    }
}
