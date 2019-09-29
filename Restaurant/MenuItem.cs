using System;
namespace Restaurant
{
    public class MenuItem
    {
        private static int nextItemId = 1;
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool NewItem { get; set; }

        public MenuItem(string name, string description,
            string category, double price, bool newItem = true)
        {
            ItemId = nextItemId++;
            Name = name;
            Description = description;
            Category = category;
            Price = price;
            NewItem = newItem;
        }

        public static bool IsNewItem(MenuItem item)
        {
            return item.NewItem;
        }

        public static bool IsSameItem(MenuItem item1, MenuItem item2)
        {
            if (item1.ItemId == item2.ItemId)
                return true;
            return false;
        }
    }
}
