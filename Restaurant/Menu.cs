using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class Menu
    {
        private static int nextMenuID = 1;
        private int MenuId { get; set; }
        public string RestaurantName { get; set; }
        private List<MenuItem> MenuItems { get; set; }
        private DateTime LastUpdateDate { get; set; }


        public Menu(string restaurantName)
        {
            MenuId = nextMenuID++;
            RestaurantName = restaurantName;
            MenuItems = new List<MenuItem>();
            LastUpdateDate = DateTime.Now;
        }

        public void AddMenuItem (MenuItem item)
        {
            MenuItems.Add(item);
            LastUpdateDate = DateTime.Now;
        }
        public void RemoveMenuItem(MenuItem item)
        {
            MenuItems.Remove(item);
            LastUpdateDate = DateTime.Now;
        }

        public string GetLastUpdate()
        {
            return LastUpdateDate.ToString(); //ToLongDateString();
        }

        

        public override String ToString()
        {
            string menuContents = RestaurantName + " Menu:\n";
            foreach (MenuItem item in MenuItems)
            {
                menuContents += item + "\n";
            }
            return menuContents;

        }

        public override bool Equals(Object o)
        {
            if (o == this)
                return true;

            if (o == null)
                return false;

            if (o.GetType() != GetType())
                return false;

            Menu menuObj = o as Menu;
            return MenuId == menuObj.MenuId;
        }

        public override int GetHashCode()
        {
            return MenuId;
        }


    }
}
