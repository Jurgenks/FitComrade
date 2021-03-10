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

        public List<Products> findAll()
        {
            Products = _context.Products.ToList();
            return Products;
        }

        public Products find(int id)
        {
            return _context.Products.Where(m => m.ID == id).FirstOrDefault();
        }

    }
}
