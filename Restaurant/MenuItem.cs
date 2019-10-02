using System;
namespace Restaurant
{
    public class MenuItem
    {
        private static int nextItemId = 1;
        private int ItemId { get; set; }
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

        public bool IsNewItem()
        {
            return NewItem;
        }

        

        public override String ToString()
        {
            string newFood = "";
            if (NewItem == true)
            {
                newFood = "\nNEW!";
            }
            return "\nName: " + Name + "\nDescription: " +
                              Description + "\nCategory: " +
                              Category + "\nPrice: $" +
                              Price.ToString() + newFood;
        }

        public override bool Equals(Object o)
        {
            if (o == this)
                return true;

            if (o == null)
                return false;

            if (o.GetType() != GetType())
                return false;

            MenuItem itemObj = o as MenuItem;
            return ItemId == itemObj.ItemId;
        }

        public override int GetHashCode()
        {
            return ItemId;
        }
    }
}
