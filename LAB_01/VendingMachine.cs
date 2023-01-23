using System;
using System.Collections.Generic;
using System.Linq;
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
            MoneyFloat = new Dictionary<int, int>();
            Inventory = new Dictionary<string, int>();  
        }

        // METHOD
        public string StockItem(string Product, int quantity)
        {
            Inventory[Product] = quantity;
            return $"{String.Join(", ", Product)}, added successfully.";
        }

        public string StockFloat(int moneyDenomination, int quanity)
        {
            MoneyFloat[moneyDenomination] = quanity;
            return String.Join(", ", MoneyFloat);
        }
    }
}
