using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopIndie.Models
{
    public class Product
    {

        // Primary Key
        public int ProductID { get; set; }

        // Properties
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        // Foreign Key

        // Navigational Properties
        public Theme Theme { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}

