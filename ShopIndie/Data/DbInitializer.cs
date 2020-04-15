using ShopIndie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopIndie.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products
            if (context.Products.Any())
            {
                return; // DB has been seeded
            }

            var products = new Product[]
            {
               new Product
               {
                   Name="Hargraft - Wild Case",
                   Price= 86,
                   Description="lorum ipsum",
                   ImageUrl = "https://placeholder.com/",
                   ThemeID = 1               },
               new Product
               {
                   Name="Might Vibe Spotify Player",
                   Price= 80,
                   Description="lorum ipsum",
                   ImageUrl = "https://placeholder.com/",
                   ThemeID = 2               },
               new Product
               {
                   Name="Totebook (2 Pack)",
                   Price= 20,
                   Description="lorum ipsum",
                   ImageUrl = "https://placeholder.com/",
                   ThemeID = 3
               },
               new Product
               {
                   Name="Oura Smart Ring",
                   Price= 314,
                   Description="lorum ipsum",
                   ImageUrl = "https://placeholder.com/",
                   ThemeID = 4
               },
               new Product
               {
                   Name="Klean Kanteen Insulated TKPro",
                   Price= 45,
                   Description="lorum ipsum",
                   ImageUrl = "https://placeholder.com/",
                   ThemeID = 5
               }
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();

            var categories = new Category[]
            {
                new Category
                {
                    CategoryName = CategoryName.PhoneCases
                },
                new Category
                {
                    CategoryName = CategoryName.Audio
                },
                new Category
                {
                    CategoryName = CategoryName.Notebooks
                },
                new Category
                {
                    CategoryName = CategoryName.Sleep
                },
                new Category
                {
                    CategoryName = CategoryName.WaterBottles
                }
            };
            foreach (Category c in categories)
            {
                context.Categories.Add(c);
            }
            context.SaveChanges();

            var productcategories = new ProductCategory[]
            {
                new ProductCategory
                {
                    CategoryID = 1,
                    ProductID = 1
                },
                new ProductCategory
                {
                    CategoryID = 2,
                    ProductID = 2
                },
                new ProductCategory
                {
                    CategoryID = 3,
                    ProductID = 3
                },
                new ProductCategory
                {
                    CategoryID = 4,
                    ProductID = 4
                },
                new ProductCategory
                {
                    CategoryID = 5,
                    ProductID = 5
                },
            };
            foreach (ProductCategory pc in productcategories)
            {
                context.ProductCategories.Add(pc);
            }
            context.SaveChanges();

            var producthemes = new Theme[]
            {
                new Theme
                {
                    ThemeName = ThemeName.Tech,
                },
                new Theme
                {
                    ThemeName = ThemeName.Audio,
                },
                new Theme
                {
                    ThemeName = ThemeName.Stationery,
                },
                new Theme
                {
                    ThemeName = ThemeName.Sleep,
                },
                new Theme
                {
                    ThemeName = ThemeName.Bottles,
                },
            };
            foreach (Theme t in producthemes)
            {
                context.Themes.Add(t);
            }
            context.SaveChanges();
        }
    }
}
