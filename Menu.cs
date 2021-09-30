using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class Menu
    {
        public List<MenuItem> MenuItems { get { return menuItems; } set { menuItems = value; } }
        private List<MenuItem> menuItems;
        private DateTime LastUpdate;

        public Menu(List<MenuItem> Dishes)
        {
            menuItems = Dishes;
            LastUpdate = DateTime.Now;
        }

        public void AddItems(List<MenuItem> NewItems, DateTime CurrentDate)
        {
            LastUpdate = CurrentDate;
            for (int i = 0; i < NewItems.Count; i++)
            {
                menuItems.Add(NewItems[i]);
            }
        }

        public void RemoveItem(int Index)
        {
            menuItems.RemoveAt(Index);
        }

        public void DisplayItems()
        {
            foreach (MenuItem Dish in menuItems)
            {
                Console.WriteLine($"Menu Number: {menuItems.IndexOf(Dish)}\n");
                Dish.ReadInfo();
            }
        }
    }
}
