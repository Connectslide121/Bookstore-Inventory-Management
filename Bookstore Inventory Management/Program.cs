// See https://aka.ms/new-console-template for more information

using Bookstore_Inventory_Management;
using System.Text.Json;

List<Book> inventory = InventoryManager.CreateInventory();

//AccountingManager.TotalValue(inventory);
//AccountingManager.TotalCost(inventory);
//AccountingManager.TotalBenefit(inventory);

//InventoryManager.UpdateBookQuantityByISBN(inventory);
//InventoryManager.UpdateBookQuantityByISBN(inventory);
//InventoryManager.UpdateBookQuantityByISBN(inventory);
//InventoryManager.UpdateBookQuantityByISBN(inventory);

//AccountingManager.TotalValue(inventory);
//AccountingManager.TotalCost(inventory);
//AccountingManager.TotalBenefit(inventory);

//InventoryManager.AddBook(inventory);

//AccountingManager.TotalValue(inventory);
//AccountingManager.TotalCost(inventory);
//AccountingManager.TotalBenefit(inventory);

//InventoryManager.SearchForBooks(inventory);

InventoryManager.SaveInventory(inventory);

Console.ReadKey();



