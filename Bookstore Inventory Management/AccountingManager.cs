using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Inventory_Management
{
    public class AccountingManager
    {
        //******************************************************************************************************************************************************//

        public static void BenefitPerBook(List<Book> inventory)
        {
            List<Book> sortedByBenefitPerBook = inventory
                .OrderByDescending(book => book.Benefit)
                .ToList();

            foreach(Book item in sortedByBenefitPerBook)
            {
                Console.WriteLine($"Benefit: {item.Benefit} \t Quantity: {item.Quantity} \t ISBN: {item.Isbn} \t Title: {item.Title}");
            }
        }

        //******************************************************************************************************************************************************//

        public static void BenefitPerBookSold(List<Book> inventory)
        {
            List<Book> sortedByBenefitPerBookSold = inventory
                .OrderByDescending (book => book.BenefitSold)
                .ToList();

            foreach(Book item in sortedByBenefitPerBookSold)
            {
                Console.WriteLine($"Total benefit sold: {item.BenefitSold} \t Quantity sold: {item.QuantitySold} \t  ISBN: {item.Isbn} \t Title: {item.Title}");
            }
        }

        //******************************************************************************************************************************************************//

        public static void TotalValue(List<Book> inventory)
        {
            int totalValue = 0;

            foreach(Book item in inventory)
            {
                totalValue += item.Price * item.Quantity;
            }

            Console.WriteLine($"The total value of the inventory is: {totalValue} SEK");
        }

        //******************************************************************************************************************************************************//

        public static void TotalCost(List<Book> inventory)
        {
            int totalCost = 0;

            foreach (Book item in inventory)
            {
                totalCost += item.Cost * item.Quantity;
            }

            Console.WriteLine($"The total cost of the inventory is: {totalCost} SEK");
        }

        //******************************************************************************************************************************************************//

        public static void TotalBenefit(List<Book> inventory)
        {
            int totalBenefit = 0;

            foreach (Book item in inventory)
            {
                int totalBenefitPerBook = item.Benefit * item.Quantity;
                totalBenefit += totalBenefitPerBook;
            }

            Console.WriteLine($"The total potential benefit of the inventory is: {totalBenefit} SEK");
        }

        //******************************************************************************************************************************************************//

    }
}
