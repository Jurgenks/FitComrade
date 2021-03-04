using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitComrade.Entities;

namespace FitComrade.Models
{
    public class ProductModel
    {
        private List<Product> Products;

        public ProductModel()
        {
            Products = new List<Product>() {
                new Product
                {
                    Id = "p01",
                    Name = "name 1",
                    Price = 4,
                    Photo = "FitComrade logo.png"
                },
                new Product
                {
                    Id = "p02",
                    Name = "name 2",
                    Price = 2,
                    Photo = "FitComrade logo.png"
                },
                new Product
                {
                    Id = "p03",
                    Name = "name 3",
                    Price = 8,
                    Photo = "FitComrade logo.png"
                }
            };
        }

        public List<Product> findAll()
        {
            return Products;
        }

        public Product find(string id)
        {
            return Products.Where(p => p.Id == id).FirstOrDefault();
        }

    }
}
