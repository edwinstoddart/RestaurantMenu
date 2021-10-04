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

        public void AddItem(MenuItem NewItem, DateTime CurrentDate)
        {
            int CheckCount = 0;
            LastUpdate = CurrentDate;

            foreach (MenuItem item in _menuItems)
            {
                item.CheckAddDate(LastUpdate);
                if (!item.Equals(NewItem)) { CheckCount++; }
            }

            if (CheckCount == (_menuItems.Count))
            {
                _menuItems.Add(NewItem);
                Console.WriteLine($"{NewItem.Name} has been added to the menu!!");
            }
            else
            {
                Console.WriteLine($"I'm sorry, {NewItem.Name} is already on the menu.");
            }
        }

        public void RemoveItem(int Index)
        {
            Console.WriteLine($"{_menuItems[Index].Name} was removed.");
            _menuItems.RemoveAt(Index);
        }

        public void DisplayAllItems()
        {
            foreach (MenuItem Dish in _menuItems)
            {
                Console.WriteLine($"Menu Number: {_menuItems.IndexOf(Dish)}");
                Console.WriteLine(Dish.ReadInfo());
            }
        }

        public void DisplaySingleItem(int Index)
        {
            Console.WriteLine(_menuItems[Index].ReadInfo());
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
