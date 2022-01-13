using System;
using System.Collections.Generic;
using Decorator.Menus;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new Menu(new List<IMenuItem>
            {
                new MenuItem("Soya Chaap",70),
                new MenuItem("Pizza",130),
                new MenuItem("Chowmein",50)
            });

            menu = new DiscountMenu(menu, 50);
            menu = new DailySpecialMenu(menu, new MenuItem("Tea", 10, true));

            foreach(IMenuItem menuItem in menu.Items)
            {
                Console.WriteLine(menuItem);
            }
        }
    }
}
