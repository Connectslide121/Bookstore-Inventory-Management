// See https://aka.ms/new-console-template for more information

using Bookstore_Inventory_Management;
using System.Text.Json;

List<Book> inventory = InventoryManager.CreateInventory("C:\\Users\\Jon\\Desktop\\Lexicon .NET\\Self study\\Bookstore Inventory Management\\Bookstore Inventory Management\\BookList.json");

AccountingManager.TotalValue(inventory);
AccountingManager.TotalCost(inventory);
AccountingManager.TotalBenefit(inventory);

InventoryManager.UpdateBookQuantityByISBN(inventory);
InventoryManager.UpdateBookQuantityByISBN(inventory);
InventoryManager.UpdateBookQuantityByISBN(inventory);
InventoryManager.UpdateBookQuantityByISBN(inventory);

AccountingManager.TotalValue(inventory);
AccountingManager.TotalCost(inventory);
AccountingManager.TotalBenefit(inventory);

InventoryManager.AddBook(inventory);

AccountingManager.TotalValue(inventory);
AccountingManager.TotalCost(inventory);
AccountingManager.TotalBenefit(inventory);

InventoryManager.SearchForBooks(inventory);

Console.ReadKey();



