using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopIndie.Models
{
    public enum CategoryName
    {
        PhoneCases,
        Charging,
        PowerBanks,
        WirelessChargers,
        AppleAccessories,
        Keyboards,
        Audio,
        Notebooks,
        Stationery,
        Sleep,
        WaterBottles,
        LunchBoxes,
        Clocks,
        Watches,
        Wallets,
        Kitchenware,
        Backpacks,
        Headwear,
        Footwear
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
