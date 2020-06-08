using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        public List<MenuItem> menuItems { get; set; }
        public DateTime menuDateTime { get; }

        public Menu(List<MenuItem> item, DateTime updateDate)
        {
            menuItems = item;
            menuDateTime = updateDate;
        }
    }
}
