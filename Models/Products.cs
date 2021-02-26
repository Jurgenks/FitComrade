using System;
using System.ComponentModel.DataAnnotations;

namespace FitComrade.Models
{
    public class Products
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Store { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Category { get; set; }
        public int Priority { get; set; }
    }
}
