// See https://aka.ms/new-console-template for more information

using Bookstore_Inventory_Management;
using System.Text.Json;

List<Book> inventory = InventoryManager.CreateInventory("C:\\Users\\Jon\\Desktop\\Lexicon .NET\\Self study\\Bookstore Inventory Management\\Bookstore Inventory Management\\BookList.json");

InventoryManager.DisplayInventory(inventory);

InventoryManager.AddBook(inventory);

List <Book> serachResult = InventoryManager.SearchForBooks(inventory);
foreach (Book item in serachResult) {Console.WriteLine($"Quantity: {item.Quantity} \t ISBN: {item.Isbn} \t Title: {item.Title} \t Categories: {string.Join("",item.Categories)}");}

InventoryManager.UpdateBookQuantityByISBN(inventory);

List<Book> serachResult2 = InventoryManager.SearchForBooks(inventory);
foreach (Book item in serachResult2) { Console.WriteLine($"Quantity: {item.Quantity} \t ISBN: {item.Isbn} \t Title: {item.Title} \t Categories: {string.Join("", item.Categories)}"); }


Console.ReadKey();



