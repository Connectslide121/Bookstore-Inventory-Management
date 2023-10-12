using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Inventory_Management
{
    public class Book
    {
        public string Title {  get; set; }
        public string Isbn { get; set; }
        public int PageCount { get; set; }
        public PublishedDate PublishedDate { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Status { get; set; }
        public string[] Authors  { get; set;}
        public string[] Categories { get; set;}
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int Quantity { get; set; }
        public int QuantitySold { get; set; }
        public int Cost { get; set; }
        public int Price { get; set; }


        public int QuantityMethod()
        {
            Random quantity = new Random();
            return quantity.Next(1,11);
        }
        public int QuantitySoldMethod()
        {
            Random quantitySold = new Random();
            return quantitySold.Next(1,101);
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
