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

            Console.WriteLine(ItalianRestaurant.GetLastUpdate());

            Console.WriteLine(Spaghetti.IsNewItem());
            Console.WriteLine(MozarellaPizza.Equals(Spaghetti));
            Console.WriteLine(MozarellaPizza);

            ItalianRestaurant.AddMenuItem(MozarellaPizza);
            ItalianRestaurant.AddMenuItem(Spaghetti);
            Console.WriteLine(ItalianRestaurant);
            ItalianRestaurant.RemoveMenuItem(Spaghetti);
            Console.WriteLine(ItalianRestaurant);
            Console.WriteLine(ItalianRestaurant.GetLastUpdate());

 
        }
    }
}
