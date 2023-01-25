using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LAB_01
{
    public class VendingMachine
    {
        // PROPERTIES
        public int SerialNumber { get; }
        public Dictionary<int, int> MoneyFloat { get; }
        public Dictionary<Product, int> Inventory { get; }

        // CONSTRUCTOR
        public VendingMachine(int serialNumber)
        {
            SerialNumber = serialNumber;
            MoneyFloat = new Dictionary<int, int>();
            Inventory = new Dictionary<Product, int>();  
        }

        // METHODS
        public string StockItem(Product product, int quantity)
        {
            Inventory[product] = quantity;
            return $"{product.ProdCode} - {product.ProdName} - ${product.ProdPrice}";
        }

        public string StockFloat(int moneyDenomination, int quantity)
        {
            MoneyFloat[moneyDenomination] = quantity;
            return $"${moneyDenomination}: {quantity} pieces";
        }

        public void VendItem(string userInput, int moneyInput)
        {
            int change = 0;
            foreach (Product item in Inventory.Keys)
            {
                if (item.ProdCode == userInput && moneyInput >= item.ProdPrice)
                {
                    Console.WriteLine($"\n~ FETCHING ITEM {item.ProdName}...");
                    change = moneyInput - item.ProdPrice;
                    Dictionary<int, int> ChangeReturned = new Dictionary<int, int>();

                    int itemCost = item.ProdPrice;
                    change = moneyInput - itemCost;
                    Inventory[item]--;

                    foreach (KeyValuePair<int, int> coins in MoneyFloat)
                    {
                        ChangeReturned.Add(coins.Key, 0);
                    }

                    foreach (KeyValuePair<int, int> pair in MoneyFloat)
                    {
                        while (pair.Key <= change && MoneyFloat[pair.Key] > 0 && change > 0)
                        {
                            change -= pair.Key;
                            ChangeReturned[pair.Key]++;
                            MoneyFloat[pair.Key]--;
                        }
                    }

                    if (change == 0)
                    {
                        Console.WriteLine("Your change is: ");
                        foreach (KeyValuePair<int, int> pair in ChangeReturned)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{pair.Value} ${pair.Key} coins");
                        }
                        Console.WriteLine($"\n~ Enjoy :)");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("~ No change available");
                        Console.WriteLine("~ Cancelling transaction...");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
