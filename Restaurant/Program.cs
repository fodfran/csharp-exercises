using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem MozarellaPizza = new MenuItem("Mozarella Pizza", "A classic pizza", "Pizza", 8.00);
            MenuItem Spaghetti = new MenuItem("Spaghetti", "A delicious pasta", "Pasta", 5.50, false);
            Menu ItalianRestaurant = new Menu("Italian Restaurant");

            Console.WriteLine(Menu.GetLastUpdate(ItalianRestaurant));

            Console.WriteLine(MenuItem.IsNewItem(Spaghetti));
            Console.WriteLine(MenuItem.IsSameItem(MozarellaPizza, Spaghetti));

            Menu.AddMenuItem(MozarellaPizza);
            Menu.AddMenuItem(Spaghetti);
            Menu.PrintMenu(ItalianRestaurant);
            Menu.RemoveMenuItem(Spaghetti);
            Menu.PrintMenu(ItalianRestaurant);
            Console.WriteLine(Menu.GetLastUpdate(ItalianRestaurant));


        }
    }
}
