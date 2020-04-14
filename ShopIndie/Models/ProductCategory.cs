using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopIndie.Models
{
    public class ProductCategory
    {
        // Primary Key
        public int ProductCategoryID { get; set; }

        // Properties
        // Foreign Key
        public int CategoryID { get; set; }
        public int ProductID { get; set; }

        // Navigational Properties
        public Category Category { get; set; }
        public Product Product { get; set; }

    }
}
