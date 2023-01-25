// VENDING MACHINE PROGRAM
// ========== PROGRAM SETUP =========
using LAB_01;
using System.Xml.Linq;

// INSTANTIATE VENDING MACHINE
VendingMachine VM = new VendingMachine(1001);

// INSTANTIATE PRODUCTS AND PASS PRODUCTS TO 'STOCKITEM' METHOD
Console.WriteLine("~ SNACKS AVAILABLE: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(VM.StockItem(new Product("Chocolate bar", 3, "A1"), 13));
Console.WriteLine(VM.StockItem(new Product("Bag of chips", 2, "A2"), 7));
Console.WriteLine(VM.StockItem(new Product("Soda pop", 3, "A3"), 6));
Console.WriteLine(VM.StockItem(new Product("Cup noodles", 4, "A4"), 9));
Console.WriteLine(VM.StockItem(new Product("Snackbox", 7, "A5"), 5));
Console.WriteLine(VM.StockItem(new Product("Lunch kit", 10, "A6"), 3));
Console.WriteLine(VM.StockItem(new Product("Pizza Sub", 6, "A7"), 8));
Console.WriteLine(VM.StockItem(new Product("Jar of pickles", 8, "A8"), 2));
Console.ResetColor();

// PASS MONEY TO 'STOCKFLOAT' METHOD
Console.WriteLine("\n~ CHANGE AVAILABLE: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(VM.StockFloat(20, 4));
Console.WriteLine(VM.StockFloat(10, 2));
Console.WriteLine(VM.StockFloat(5, 2));
Console.WriteLine(VM.StockFloat(2, 3));
Console.WriteLine(VM.StockFloat(1, 10));
Console.ResetColor();

// GETTING MONEY INPUT FROM USER AND ITEM OF CHOICE
int moneyInput = 0;
string itemChoice = "";
bool runningTransaction = false;

// VALIDATE IF ITEM EXISTS
while (!runningTransaction)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\n~ Please enter your bill: ");
    Console.ResetColor();
    moneyInput = Int32.Parse(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"~ Please enter the item code of your liking: ");
    Console.ResetColor();
    itemChoice = Console.ReadLine().ToUpper();

    VM.VendItem(itemChoice, moneyInput);
}





