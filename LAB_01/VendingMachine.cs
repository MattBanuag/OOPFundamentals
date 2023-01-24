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

        // METHOD
        public string StockItem(Product product, int quantity)
        {
            Inventory[product.ProdCode] = quantity;
            return $"{product.ProdName} added successfully.";
        }

        public string StockFloat(int moneyDenomination, int quanity)
        {
            MoneyFloat[moneyDenomination] = quanity;
            return String.Join(", ", MoneyFloat);
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
