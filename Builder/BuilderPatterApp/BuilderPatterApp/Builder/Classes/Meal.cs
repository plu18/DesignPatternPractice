using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatterApp.Builder.Classes
{
    class Meal
    {
        private List<Item> _items = new List<Item>(); 

        public void addItem(Item item)
        {
            _items.Add(item);
        }

        public float getCost()
        {
            float cost = 0;

            foreach (Item item in _items)
            {
                cost += item.price();
            }
            return cost;
        }

        public void showItems()
        {
            foreach (Item item in _items)
            {
                Console.WriteLine("Item: "+item.name());
                Console.WriteLine("Price: " + item.price());
                Console.WriteLine("Packing: " + item.packing().pack());
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Total price: " + getCost());
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
