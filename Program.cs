using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter shopping item, to quit 'q'.");

            var shoppingList = new List<ShoppingItem>();
            while (true)
            {
                Console.Write("Name: ");
                var itemName = Console.ReadLine();
                if (itemName == "q")
                {
                    break;
                }

                Console.Write("Price:");
                var itemPrice = double.Parse(Console.ReadLine());
                var shoppingItem = new ShoppingItem(itemPrice, itemName);
                shoppingList.Add(shoppingItem);
            }

            var sum = Helper.CalculatePrice(shoppingList);
            Console.WriteLine($"Total Price: {sum:C}");
        }
    }
}