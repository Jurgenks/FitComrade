﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitComrade.Entities;

namespace FitComrade.Models
{
    public class ProductModel
    {
        private readonly FitComrade.Data.FitComradeContext _context;

        public ProductModel(FitComrade.Data.FitComradeContext context)
        {
            _context = context;
        }

        public List<Products> Products { get; set; }

        public List<Products> FindAll() // Ontvang alle Producten uit database
        {
            Products = _context.Products.ToList();
            return Products;
        }
        public List<Products> FindProductName(string name) // Ontvang de benaming van ieder product
        {
            var products = from m in _context.Products
                           select m;
            products = _context.Products.Where(m => m.ProductName.Contains(name));
            Products = products.ToList(); 
            return Products;
        }

        public Products Find(int id) // Haal het gevraagde product op
        {
            return _context.Products.Where(m => m.ID == id).FirstOrDefault();
        }

    }
}
