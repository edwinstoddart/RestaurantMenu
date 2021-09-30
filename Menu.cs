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
            this.LastUpdate = CurrentDate;
            
        }
    }
}
