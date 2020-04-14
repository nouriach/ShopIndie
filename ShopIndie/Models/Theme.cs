using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopIndie.Models
{
    public class Theme
    {
        // Primary Key

        // Properties
        public string ThemeName { get; set; }
        // Foreign Key

        // Navigational Properties
        [Key]
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
