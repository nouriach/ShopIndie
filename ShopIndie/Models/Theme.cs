using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopIndie.Models
{
    public enum ThemeName
    {
        Tech,
        Audio,
        Stationery,
        Sleep,
        Bottles,
        LunchBoxes,
        Time,
        Wallets,
        Homeware,
        Luggage,
        Headware,
        Footwear
    }
    public class Theme
    {
        // Primary Key
        public int ThemeID { get; set; }

        // Properties
        public ThemeName? ThemeName { get; set; }
        // Foreign Key

        // Navigational Properties
        public ICollection<Product> Product { get; set; }
    }
}
