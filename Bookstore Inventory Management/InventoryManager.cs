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

        //******************************************************************************************************************************************************//

        public static List<Book> AddBook(List<Book> inventory)
        {
            Console.WriteLine("Let's add a new book:");
            Book newBook = new Book();

            Console.WriteLine("Title:");
            newBook.Title = Console.ReadLine();

            Console.WriteLine("ISBN:");
            newBook.Isbn = Console.ReadLine();

            Console.WriteLine("Page count:");
            bool validPageCount = false;
            do
            {
                string pageCount = Console.ReadLine();

                if(int.TryParse(pageCount, out int pageCountInt))
                {
                    validPageCount = true;
                    newBook.PageCount = pageCountInt;
                }
                else { Console.WriteLine("Invalid input. Please enter a number"); }

            }while(validPageCount==false);

            Console.WriteLine("Published date (YYYY-MM-DD hh:mm:ss):");
            bool validPublishedDate = false;
            do
            {
                string publishedDate = Console.ReadLine();

                if(DateTime.TryParse(publishedDate, out DateTime publishedDateTime))
                {
                    validPublishedDate = true;
                    PublishedDate newPublishedDate = new PublishedDate();
                    newPublishedDate.Date = publishedDateTime;
                    newBook.PublishedDate = newPublishedDate;
                }
                else { Console.WriteLine("Invalid input. Please enter a valid date and time (YYYY-MM-DD hh:mm:ss)"); }

            }while (validPublishedDate==false);

            Console.WriteLine("Thumbnail URL:");
            newBook.ThumbnailUrl = Console.ReadLine();

            Console.WriteLine("Status:");
            newBook.Status = Console.ReadLine();

            Console.WriteLine("Author/s (separated by commas):");
            newBook.Authors = Console.ReadLine().Split(',');

            Console.WriteLine("Categories (separated by commas):");
            newBook.Categories = Console.ReadLine().Split(',');

            Console.WriteLine("Short description:");
            newBook.ShortDescription = Console.ReadLine();

            Console.WriteLine("Long description");
            newBook.LongDescription = Console.ReadLine();

            Console.WriteLine("Quantity:");
            bool validQuantity = false;
            do
            {
                string quantity = Console.ReadLine();

                if (int.TryParse(quantity, out int quantityInt))
                {
                    validQuantity = true;
                    newBook.Quantity = quantityInt;
                }
                else { Console.WriteLine("Invalid input. Please enter a number"); }

            } while (validQuantity == false);

            Console.WriteLine("Cost:");
            bool validCost = false;
            do
            {
                string cost = Console.ReadLine();

                if (int.TryParse(cost, out int costInt))
                {
                    validCost = true;
                    newBook.Cost = costInt;
                }
                else { Console.WriteLine("Invalid input. Please enter a number"); }

            } while (validCost == false);

            Console.WriteLine("Price:");
            bool validPrice = false;
            do
            {
                string price = Console.ReadLine();

                if(int.TryParse(price, out int priceInt))
                {
                    validPrice = true;
                    newBook.Price = priceInt;
                }
                else { Console.WriteLine("Invalid input.Please enter a number"); }

            }while (validPrice == false);

            Console.WriteLine("Quantity sold:");
            bool validQuantitySold = false;
            do
            {
                string quantitySold = Console.ReadLine();

                if (int.TryParse(quantitySold, out int quantitySoldInt))
                {
                    validQuantitySold = true;
                    newBook.QuantitySold = quantitySoldInt;
                }
                else { Console.WriteLine("Invalid input.Please enter a number"); }

            }while(validQuantitySold == false);

            inventory.Add(newBook);

            return inventory;
        }

        //******************************************************************************************************************************************************//

        public static List<Book> DisplayInventory(List<Book> inventory)
        {
            string inventoryDisplay = "";

            foreach (Book item in inventory)
            {
                inventoryDisplay += $"Quantity: {item.Quantity} \t ISBN: {item.Isbn} \t Title: {item.Title} \n";
            }

            Console.WriteLine(inventoryDisplay);

            return inventory;
        }

        //******************************************************************************************************************************************************//

        public static List<Book> SearchForBooks(List<Book> searchInventory)
        {
            Console.WriteLine("Enter search query (Title, ISBN, Author, Category or Description):");
            string searchInput = Console.ReadLine().ToLower();

            List<Book> searchResult = searchInventory
                .Where(Book => 
                    Book.Title.ToLower().Contains(searchInput) ||
                    Book.Isbn.ToLower().Contains(searchInput) ||
                    string.Join("",Book.Authors).ToLower().Contains(searchInput) ||
                    string.Join("",Book.Categories).ToString().ToLower().Contains(searchInput)||
                    Book.ShortDescription.ToLower().Contains(searchInput)||
                    Book.LongDescription.ToLower().Contains(searchInput))
                .ToList();

            return searchResult;
        }

        //******************************************************************************************************************************************************//

        public static List<Book> UpdateBookQuantityByISBN(List<Book> inventory)
        {
            Console.WriteLine("Enter ISBN of book to update:");
            string ISBN = Console.ReadLine();

            Console.WriteLine("Enter new Quantity:");
            int newQuantityInt;
            bool validNewQuantity = false;
                       
            do
            {
                string newQuantity = Console.ReadLine();

                if (int.TryParse(newQuantity, out newQuantityInt))
                {
                    validNewQuantity = true;
                }
                else { Console.WriteLine("Invalid input.Please enter a number"); }

            } while (validNewQuantity == false);

            Book BookToUpdate = inventory.Find(book => book.Isbn == ISBN);

            if (BookToUpdate == null)
            {
                Console.WriteLine("Book not found.");
            }
            else
            {
                BookToUpdate.Quantity = newQuantityInt;
            }

            return inventory;
        }

        //******************************************************************************************************************************************************//

    }
}
