using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitComrade.Data;
using FitComrade.Models;


namespace FitComrade.Pages.Supplementen
{
    public class VoorraadModel : PageModel
    {
        
        private readonly FitComrade.Data.FitComradeContext _context;

        public VoorraadModel(FitComrade.Data.FitComradeContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Category { get; set; }

       
        public async Task OnGetAsync()
        {
            var products = from m in _context.Products
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                products = products.Where(s => s.ProductName.Contains(SearchString));
            }
            
            Products = await products.ToListAsync();
        }
        




    }
}
