using System;
using System.Collections.Generic;

namespace ironNinja
{
    class Buffet
    {
        public List<IConsumable> Menu;
    
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Drink("Beer", 170, false),
                new Drink("Blood Mary", 250, true),
                new Drink("Coffee", 5, false),
                new Drink("Soda", 80, false),
                new Food("Donuts", 700, false, true),
                new Food("Steak", 1200, false, false),
                new Food("Snickers", 150, false, true),
                new Food("Potato", 200, false, false),
                new Food("Curry & Rice", 800, true, false),
                new Food("Fries", 400, false, false)
                
            };
        }


        public IConsumable Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }

}