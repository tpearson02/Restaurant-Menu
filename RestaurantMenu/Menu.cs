using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Menu

    {
        //field for time menu was updated
        public DateTime menuDateTime;

        // Declare List to Store Menu Items
        private List<MenuItem> MenuItems;
        private DateTime lastupdate;

        public Menu()
        {
            this.MenuItems = new List<MenuItem>();
        }

        // Method to Add Items to List
       public void AddItem(double price, string description , string category)
        {
            MenuItem AddedItem = new MenuItem(price, description, category);
            MenuItems.Add(AddedItem);
            lastupdate = DateTime.Now;
        }
        public void RemoveItem(string description)
        {
            foreach (MenuItem item in MenuItems)
            {
                if (description.ToUpper().Equals(item.ItemDescription.ToUpper()))
                {
                    MenuItems.Remove(item);
                }
            }
        }

        // Method to Print Item in List
        public void PrintItems()
        {
            foreach(MenuItem menuItem in MenuItems)
            { // if/ else for date comparison of new item

                DateTime fourteenDaysPrior = menuItem.itemDateTime.AddDays(14);
                //Console.WriteLine(fourteenDaysPrior);
                if (menuItem.itemDateTime.CompareTo(fourteenDaysPrior) <= 14)
                {
                    Console.WriteLine($"\"NEW\" { menuItem.ItemCategory} | { menuItem.ItemDescription} | { menuItem.ItemPrice}");
                }
                else
                {
                    Console.WriteLine($"{menuItem.ItemCategory} | {menuItem.ItemDescription} | {menuItem.ItemPrice}");
                }

            }

           Console.WriteLine($"\nLast update of menu: {lastupdate}");


        }
    }
}
