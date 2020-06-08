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
            MenuItems = [];
            MenuDateTime = menuDateTime;
        }

        public void AddItem(MenuItem item) 
        {
            menuItems.Add(item);
        }

        public void RemoveItem(MenuItem item)
        {
            int menuIndex = menuItems.IndexOf(item);
            menuItems.RemoveAt(menuIndex);
        }


        public bool IsNew(MenuItem item)
        {
            return item.IsNew;
        }

        public DateTime LastUpdated(Menu obj)
        {
            return obj.menuDateTime;
        }

        public void PrintMenu()
        {
            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine(menuItems[i]);
            }         
        }

        public void PrintMenuItem(MenuItem item)
        {
            int menuIndex = menuItems.IndexOf(item);
            Console.WriteLine(menuItems[menuIndex]);
        }

        public override bool Equals(object toBeCompared)
        {
            if (toBeCompared == null)
            {
                return false;
            }
            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }
            Menu s = toBeCompared as Menu;
            return s.MenuItems == MenuItems;
        }
    }
}

//MenuItem pizza = new MenuItem;
//menu.AddItem(pizza);

//can we return a Menu Class from an instance method?
//Do we even have to make a new Menu class --I'm assuming the answer is yes because we need to update the time

//public void RemoveItem(List<MenuItem> item)
//{
//    menuItems = item;
//}

