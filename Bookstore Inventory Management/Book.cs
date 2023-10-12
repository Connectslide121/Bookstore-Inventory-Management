using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Inventory_Management
{
    public class Book
    {
        public string Title { get; set; } = "null";
        public string Isbn { get; set; } = "null";
        public int PageCount { get; set; } = 0;
        public PublishedDate PublishedDate { get; set; } = new PublishedDate();
        public string ThumbnailUrl { get; set; } = "null";
        public string Status { get; set; } = "null";
        public string[] Authors  { get; set;} = new string[0];
        public string[] Categories { get; set;} = new string[0];
        public string ShortDescription { get; set; } = "null";
        public string LongDescription { get; set; } = "null";
        public int Quantity { get; set; }
        public int QuantitySold { get; set; }
        public int Cost { get; set; }
        public int Price { get; set; }


        public int QuantityMethod()
        {
            Random quantity = new Random();
            return quantity.Next(0,11);
        }
        public int QuantitySoldMethod()
        {
            Random quantitySold = new Random();
            return quantitySold.Next(0,101);
        }
        public int CostMethod()
        {
            Random cost = new Random();
            return cost.Next(1,10);
        }
        public int PriceMethod()
        {
            Random price = new Random();
            return price.Next(11,50);
        }

        public Book() //CONSTRUCTOR
        {
            Quantity = QuantityMethod();
            QuantitySold = QuantitySoldMethod();
            Cost = CostMethod();
            Price = PriceMethod();
        }

    }
}
