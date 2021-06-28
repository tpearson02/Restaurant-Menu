/* June 28, 2021.
 * LaunchCode
 * Chapter 18 Studio: Classes in C#, Part 1
 * Restaurant Menu
 * Julian Munar & Tatyana Pearson
 */

using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nItalian Bistro Menu");
            
            Menu MenuOne = new Menu();
            MenuOne.AddItem(8.99, "Mozzarella Sticks", "Appetizer");
            MenuOne.AddItem(10.99, "Calamari", "Appetizer");
            MenuOne.AddItem(19.99, "Fettuccine Alfredo with Chicken", "Main Course");
            MenuOne.AddItem(15.99, "Spaghetti with Meatballs", "Main Course");
            MenuOne.AddItem(5.99, "Tiramisu", "Dessert");
            MenuOne.AddItem(6.99, "Cannoli", "Dessert");

            Console.WriteLine("\n");
            MenuOne.PrintItems();


        }
    }
}
