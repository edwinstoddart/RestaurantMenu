using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class MenuItem
    {
        public string Name { get { return name; } set { name = value; } }
        private string name;
        public double Price { get { return price; } set { price = value; } }
        private double price;
        public string Description { get { return description; } set { description = value; } }
        private string description;
        public string Category { get { return category; } set { category = value; } }
        private string category;
        private DateTime AddDate;
        public bool NewItem { get { return newItem; } set { newItem = value; } }
        private bool newItem;

        public MenuItem(string Name, double Price, string Description,
            string Category, bool NewItem = true)
        {
            name = Name;
            price = Price;
            description = Description;
            category = Category;
            AddDate = DateTime.Now;
            newItem = NewItem;
        }

        public void CheckAddDate(DateTime LastUpdate)
        {
            int CheckDate = DateTime.Compare(this.AddDate, LastUpdate);
            if (CheckDate < 0)
            {
                newItem = false;
            } else {
                newItem = true;
            }
        }

        public void ReadInfo()
        {
            Console.WriteLine($"{name}\n" +
                $"{price}\n" +
                $"{description}\n" +
                $"{(newItem ? "New!!": "")}");
        }
    }
}
