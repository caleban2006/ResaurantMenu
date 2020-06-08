using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        public List<MenuItem> MenuItems { get; set; }
        public DateTime MenuDateTime { get; }

        public Menu(DateTime menuDateTime)
        {
            MenuItems = new List<MenuItem>();
            MenuDateTime = menuDateTime;
        }

        public void AddItem(MenuItem item) 
        {
            if (MenuItems.IndexOf(item) == -1)
            {
                MenuItems.Add(item);
            }
            else
            {
                Console.WriteLine("The menu already has this item.");
            }
        }

        public void RemoveItem(MenuItem item)
        {
            int menuIndex = MenuItems.IndexOf(item);
            MenuItems.RemoveAt(menuIndex);
        }


        public bool IsNew(MenuItem item)
        {
            return item.IsNew;
        }

        public DateTime LastUpdated(Menu obj)
        {
            return obj.MenuDateTime;
        }

        public void PrintMenu()
        {
            for (int i = 0; i < MenuItems.Count; i++)
            {
                Console.WriteLine(MenuItems[i]);
            }         
        }

        public void PrintMenuItem(MenuItem item)
        {
            int menuIndex = MenuItems.IndexOf(item);
            Console.WriteLine(MenuItems[menuIndex]);
        }
    
    }
}