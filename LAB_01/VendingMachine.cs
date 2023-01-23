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
        public string StockItem(string prodName, int prodPrice, string prodCode)
        {
            Inventory[$"{prodCode} - {prodName}"] = prodPrice;
            return $"{prodCode} - {prodName}, has been added.";
        }
    }
}
