using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Menu
    {
        // Declare List to Store Menu Items
       private List<MenuItem> MenuItems;
        public Menu()
        {
            this.MenuItems = new List<MenuItem>();
        }

        // Method to Add Items to List
       public void AddItem(double price, string description , string category)
        {
            MenuItem AddedItem = new MenuItem(price, description, category);
            MenuItems.Add(AddedItem);
        }

        // Method to Print Item in List
        public void PrintItems()
        {
            foreach(MenuItem menuItem in MenuItems)
            {
                Console.WriteLine($"{menuItem.ItemCategory} | {menuItem.ItemDescription} | {menuItem.ItemPrice} | {menuItem.itemDateTime}");
            }
        }
    }
}
