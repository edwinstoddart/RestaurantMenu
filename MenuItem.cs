using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class MenuItem
    {
        public string Name { get; set; }
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
            int CheckDate = DateTime.Compare(_addDate, LastUpdate);
            if (CheckDate < 0)
            {
                NewItem = false;
            } else {
                NewItem = true;
            }
        }

        public string ReadInfo()
        {
            string Str = $"{Name}\n" +
                $"{Price}\n" +
                $"{Description}\n" +
                $"{(NewItem ? "New!!": "")}\n";
            return Str;
        }

        public override bool Equals(object obj)
        {
            return obj is MenuItem item &&
                   Name == item.Name &&
                   Category == item.Category;
        }
    }
}
