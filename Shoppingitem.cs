using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList
{
    class ShoppingItem
    {
        private double price;
        private string name;

        public ShoppingItem(double price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public double GetPrice()
        {
            return price;
        }

        public string GetInfo()
        {
            return $"Item: {name}, price:{price:C}";
        }
    }
}
