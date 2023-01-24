// VENDING MACHINE PROGRAM
// ========== PROGRAM SETUP =========
using LAB_01;

// INSTANTIATE VENDING MACHINE
VendingMachine VM = new VendingMachine(1001);

// INSTANTIATE PRODUCTS
Product A = new Product("Chocolate bar", 3, "A1");
Product B = new Product("Bag of chips", 2, "B2");
Product C = new Product("Soda pop", 3, "C3");
Product D = new Product("Cup noodles", 4, "D4");
Product E = new Product("Snackbox", 7, "E5");
Product F = new Product("Lunch kit", 10, "F6");
Product G = new Product("Pizza Sub", 6, "G7");
Product H = new Product("Jar of pickles", 8, "H8");

// PASS PRODUCTS TO 'STOCKITEM' METHOD
Console.WriteLine("~ SNACKS AVAILABLE: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(VM.StockItem(A, 13));
Console.WriteLine(VM.StockItem(B, 7));
Console.WriteLine(VM.StockItem(C, 6));
Console.WriteLine(VM.StockItem(D, 9));
Console.WriteLine(VM.StockItem(E, 5));
Console.WriteLine(VM.StockItem(F, 3));
Console.WriteLine(VM.StockItem(G, 8));
Console.WriteLine(VM.StockItem(H, 2));
Console.ResetColor();

// PASS MONEY TO 'STOCKFLOAT' METHOD
Console.WriteLine("\n~ CHANGE AVAILABLE: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(VM.StockFloat(20, 4));
Console.WriteLine(VM.StockFloat(10, 0));
Console.WriteLine(VM.StockFloat(5, 2));
Console.WriteLine(VM.StockFloat(2, 0));
Console.WriteLine(VM.StockFloat(1, 10));
Console.ResetColor();
