using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopIndie.Models
{
    public enum CategoryName
    {
        Tech, Audio, Stationery, Sleep, Wallets
    }
    public class Category
    {
        // Primary Key
        public int CategoryID { get; set; }

        // Properties
        public CategoryName? CategoryName { get; set; }

        // Foreign Key

        // Navigational Properties
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
