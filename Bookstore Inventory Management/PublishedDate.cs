using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Inventory_Management
{

    //THIS CLASS EXISTS ONLY BECAUSE THE DATE IN THE JSON FILE THAT I DOWNLOADED WAS STORED AS AN OBJECT. I USED THIS CLASS TO BE ABLE TO DESERIALIZE THE JSON FILE
    public class PublishedDate
    {
        public DateTime Date { get; set; }
    }
}
