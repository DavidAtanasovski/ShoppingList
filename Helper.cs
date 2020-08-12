using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList
{
    class Helper
    {
        public static double CalculatePrice(List<ShoppingItem> list)
        {
            var sum = 0.0;
            foreach (var item in list)
            {
                sum += item.GetPrice();
            }

            return sum;
        }
    }
}
