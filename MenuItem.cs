using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class MenuItem
    {
        private string Name { get; set; }
        private double Price { get; set; }
        private string Description { get; set; }
        public string Category { get; set; }
        private bool NewItem { get; set; }
        private DateTime _addDate;

        public MenuItem(string name, double price, string description,
            string category, bool newItem = true)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            NewItem = newItem;
            _addDate = DateTime.Now;
        }

        public void CheckAddDate(DateTime LastUpdate)
        {
            int CheckDate = DateTime.Compare(this._addDate, LastUpdate);
            if (CheckDate < 0)
            {
                NewItem = false;
            } else {
                NewItem = true;
            }
        }

        public void ReadInfo()
        {
            Console.WriteLine($"{Name}\n" +
                $"{Price}\n" +
                $"{Description}\n" +
                $"{(NewItem ? "New!!": "")}");
        }
    }
}
