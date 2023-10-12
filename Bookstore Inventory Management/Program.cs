// See https://aka.ms/new-console-template for more information

using Bookstore_Inventory_Management;
using System.Text.Json;

List<Book> inventory = InventoryManager.CreateInventory("C:\\Users\\Jon\\Desktop\\Lexicon .NET\\Self study\\Bookstore Inventory Management\\Bookstore Inventory Management\\BookList.json");

string inventoryDisplay = InventoryManager.DisplayInventory(inventory);
Console.WriteLine(inventoryDisplay);






