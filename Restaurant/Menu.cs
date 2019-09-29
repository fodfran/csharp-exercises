using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class Menu
    {
        public static string RestaurantName { get; set; }
        public static List<MenuItem> MenuItems { get; set; }
        public static DateTime LastUpdateDate { get; set; }


        public Menu(string restaurantName)
        {
            RestaurantName = restaurantName;
            MenuItems = new List<MenuItem>();
            LastUpdateDate = DateTime.Now;
        }

        public static void AddMenuItem (MenuItem item)
        {
            MenuItems.Add(item);
            LastUpdateDate = DateTime.Now;
        }
        public static void RemoveMenuItem(MenuItem item)
        {
            MenuItems.Remove(item);
            LastUpdateDate = DateTime.Now;
        }

        public static string GetLastUpdate(Menu menu)
        {
            return LastUpdateDate.ToString(); //ToLongDateString();
        }

        public static void PrintMenu(Menu menu)
        {
            Console.WriteLine(RestaurantName + " Menu:\n");
            foreach (MenuItem item in MenuItems)
            {
                PrintMenuItem(item);
            }
        }

        public static void PrintMenuItem(MenuItem item)
        {
            Console.WriteLine("Name: " + item.Name + "\nDescription: " +
                              item.Description + "\nCategory: " +
                              item.Category + "\nPrice: $" +
                              item.Price.ToString() + "\n");
        }
    }
}
