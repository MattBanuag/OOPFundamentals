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
            bool isRunning = true;
            foreach (Product item in Inventory.Keys)
            {
                if (item.ProdCode == userInput && moneyInput >= item.ProdPrice)
                {
                    Console.WriteLine($"\n~ FETCHING ITEM {item.ProdName}...");
                    change = moneyInput - item.ProdPrice;
                    List<string> changeList = new List<string>();

                    while (change >= 20)
                    {
                        if (MoneyFloat[20] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("~ No change available");
                            Console.WriteLine("~ Cancelling transaction...");
                            Console.ResetColor();
                            isRunning = false;
                        }
                        changeList.Add("$20");
                        change -= 20;
                        MoneyFloat[20]--;
                    } while (change >= 10)
                    {
                        if (MoneyFloat[10] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("~ No change available");
                            Console.WriteLine("~ Cancelling transaction...");
                            Console.ResetColor();
                            isRunning = false;
                        }
                        changeList.Add("$10");
                        change -= 10;
                        MoneyFloat[10]--;
                    } while (change >= 5)
                    {
                        if (MoneyFloat[5] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("~ No change available");
                            Console.WriteLine("~ Cancelling transaction...");
                            Console.ResetColor();
                            isRunning = false;
                        }
                        changeList.Add("$5");
                        change -= 5;
                        MoneyFloat[5]--;
                    } while (change >= 2)
                    {
                        if (MoneyFloat[2] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("~ No change available");
                            Console.WriteLine("~ Cancelling transaction...");
                            Console.ResetColor();
                            isRunning = false;
                        }
                        changeList.Add("$2");
                        change -= 2;
                        MoneyFloat[2]--;
                    } while (change >= 1)
                    {
                        if (MoneyFloat[1] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("~ No change available");
                            Console.WriteLine("~ Cancelling transaction...");
                            Console.ResetColor();
                            isRunning = false;
                        }
                        changeList.Add("$1");
                        change -= 1;
                        MoneyFloat[1]--;
                    }

                    // Display change
                    if (isRunning)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"~ Your change is: {String.Join(", ", changeList)}");
                        Console.WriteLine();
                        Console.WriteLine($"~ Enjoy :)\n");
                        Console.ResetColor();
                        changeList.Clear();
                    }
                    break;
                }
            }
        }
    }
}
