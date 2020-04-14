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
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
        // add to view model later

        //[Range(1, 100)]
        //[DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18, 2)")]
        //public decimal Price { get; set; }