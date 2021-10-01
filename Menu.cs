using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class Menu
    {
        private List<MenuItem> _menuItems;
        private DateTime LastUpdate;

        public Menu(List<MenuItem> Dishes)
        {
            _menuItems = Dishes;
            LastUpdate = DateTime.Now;
        }

        public void AddItems(List<MenuItem> NewItems, DateTime CurrentDate)
        {
            LastUpdate = CurrentDate;
            for (int i = 0; i < NewItems.Count; i++)
            {
                _menuItems.Add(NewItems[i]);
            }
        }

        public void RemoveItem(int Index)
        {
            _menuItems.RemoveAt(Index);
        }

        public void DisplayAllItems()
        {
            foreach (MenuItem Dish in _menuItems)
            {
                Console.WriteLine($"Menu Number: {_menuItems.IndexOf(Dish)}\n");
                Dish.ReadInfo();
            }
        }

        public IReadOnlyCollection<MenuItem> DisplayCourseItems(string Course)
        {
            Course = Course.ToLower();
            List<MenuItem> CourseMenu = new List<MenuItem>();
            switch (Course)
            {
                case "appetizer":
                case "main course":
                case "dessert":
                    foreach (MenuItem Dish in _menuItems)
                    {
                        if (Course.Equals(Dish.Category))
                        {
                            CourseMenu.Add(Dish);
                        }
                    }
                ; break;
                default: Console.WriteLine("That is not a course at this restaurant."); break;
            }

            IReadOnlyCollection<MenuItem> DisplayCourse = CourseMenu.AsReadOnly();
            return DisplayCourse;
        }
    }
}
