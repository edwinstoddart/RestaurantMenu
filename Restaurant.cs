using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            MenuItem A = new MenuItem("Nutrient Paste A", 14.99, "It tastes like the color grey.", "main course");
            MenuItem B = new MenuItem("Nutrient Paste B", 11.99, "It tastes like misfortune.", "main course");
            MenuItem C = new MenuItem("Nutrient Paste C", 5.99, "It tastes like a delicious blend of strawberries and cream.", "main course");
            MenuItem D = new MenuItem("Nutrient Paste D", 9.99, "It tastes like existential horror.", "main course");
            List<MenuItem> Dishes = new List<MenuItem> {A};

            Menu NewMenu = new Menu(Dishes);
            Console.WriteLine("\nPrint the whole menu, there is only one item on it.\n");
            NewMenu.DisplayAllItems();
            Console.WriteLine("\nPress Enter key to continue and clear the console.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\nAdd two items, and then print the menu.\n");
            NewMenu.AddItem(B, DateTime.Now);
            NewMenu.AddItem(C, DateTime.Now);
            NewMenu.DisplayAllItems();
            Console.WriteLine("\nPress Enter key to continue and clear the console.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\nPrint the item at index[2].\n");
            NewMenu.DisplaySingleItem(2);
            Console.WriteLine("\nPress Enter key to continue and clear the console.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Remove an item, and then print the menu again.\n");
            NewMenu.RemoveItem(2);
            NewMenu.DisplayAllItems();
            Console.WriteLine("\nPress Enter key to continue and clear the console.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Add a new item twice (the second time will fail), and then print the menu one last time.\n");
            NewMenu.AddItem(D, DateTime.Now);
            NewMenu.AddItem(D, DateTime.Now);
            NewMenu.DisplayAllItems();
        }
    }
}
