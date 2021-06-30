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
            Console.WriteLine("------------------");
            Console.WriteLine("\nItalian Bistro Menu");
            Console.WriteLine("------------------");

            Menu MenuOne = new Menu();
            MenuItem AddedItem1 = new MenuItem (8.99, "Mozzarella Sticks", "Appetizer");
            MenuItem AddedItem2 = new MenuItem(10.99, "Calamari", "Appetizer");
            MenuItem AddedItem3 = new MenuItem (8.99, "Bruschetta", "Appetizer");
            MenuItem AddedItem4 = new MenuItem (7.99, "Bruschetta", "Appetizer");
            MenuItem AddedItem5 = new MenuItem (19.99, "Fettuccine Alfredo with Chicken", "Main Course");
            MenuItem AddedItem6 = new MenuItem(15.99, "Spaghetti with Meatballs", "Main Course");
            MenuItem AddedItem7 = new MenuItem(5.99, "Tiramisu", "Dessert");
            MenuItem AddedItem8 = new MenuItem(6.99, "Cannoli", "Dessert");
            MenuItem AddedItem9 = new MenuItem(5.99, "Chocolate Mousse", "Dessert");

            Console.WriteLine("\n");
            MenuItems.PrintItems();


        }
    }
}
