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
        public Dictionary<string, int> Inventory { get; }

        // CONSTRUCTOR
        public VendingMachine(int serialNumber)
        {
            SerialNumber = serialNumber;
            MoneyFloat = new Dictionary<int, int>()
            {
                { 20, 4 },
                { 10, 0 },
                { 5, 2 },
                { 2, 0 },
                { 1, 10 }
        };
            Inventory = new Dictionary<string, int>();  
        }

        // METHODS
        public string StockItem(Product product, int quantity)
        {
            Inventory[product.ProdCode] = quantity;
            return $"{product.ProdCode} - {product.ProdName} - ${product.ProdPrice}";
        }

        public string StockFloat(int moneyDenomination, int quantity)
        {
            MoneyFloat[moneyDenomination] = quantity;
            return $"${moneyDenomination}: {quantity} pieces";
        }

        /*public string VendItem(string Product, int quantity) 
        {
            if (!Inventory.ContainsKey(Product))
            {
                Console.WriteLine("~ ERROR: This item does not exist.");
            } else
            {
                return String.Join(", ", Inventory[Product]);
            }
        }*/
    }
}
