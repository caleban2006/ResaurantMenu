using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem calzone = new MenuItem(6.99, "tasty calzone", "Italian", true);
            MenuItem pizza = new MenuItem(8.99, "Awful", "Italian", true);
            MenuItem burger = new MenuItem(7.99, "Beefy", "French", true);

            Menu summerMenu = new Menu();

            summerMenu.AddItem(calzone);
            summerMenu.AddItem(pizza);
            summerMenu.AddItem(burger);

            summerMenu.PrintMenu();
        }
    }
}
