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


