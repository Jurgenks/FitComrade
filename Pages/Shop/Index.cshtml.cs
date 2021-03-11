using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FitComrade.Entities;
using FitComrade.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FitComrade.Pages.Shop
{
    public class IndexModel : PageModel
    {
        public List<Products> Products;
        private readonly FitComrade.Data.FitComradeContext _context;
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Category { get; set; }
        public IndexModel(FitComrade.Data.FitComradeContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            ProductModel productModel = new ProductModel(_context);
            Products = productModel.findAll();

            
            if (!string.IsNullOrEmpty(SearchString))
            {
                Products = productModel.findProductName(SearchString);
            }
            
        }
        
    }
}
