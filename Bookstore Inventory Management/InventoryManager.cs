using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bookstore_Inventory_Management
{
    public class InventoryManager
    {
        public static List<Book> CreateInventory(string filePath)
        {
            List<Book> inventory = JsonSerializer.Deserialize<List<Book>>(File.ReadAllText(filePath));

            return inventory;
        }

        public static List<Book> AddBooks(List<Book> inventory, Book BookToAdd)
        {
            return inventory;//**************************************************************************************************************
        }

        public static string DisplayInventory(List<Book> inventory)
        {
            string inventoryDisplay = "";

            foreach (Book item in inventory)
            {
                inventoryDisplay += $"Title: {item.Title} \t ISBN: {item.Isbn} \t Current quantity: {item.Quantity}\n";
            }

            return inventoryDisplay;
        }

        public static List<Book> SearchForBooks(List<Book> searchInventory, string searchInput)
        {
            searchInput = searchInput.ToLower();

            List<Book> searchResult = searchInventory
                .Where(Book => 
                    Book.Title.ToLower().Contains(searchInput) || 
                    Book.Isbn.ToLower().Contains(searchInput) || 
                    Book.Authors.ToString().ToLower().Contains(searchInput) || 
                    Book.Categories.ToString().ToLower().Contains(searchInput))
                .ToList();

            return searchResult;
        }


    }
}
