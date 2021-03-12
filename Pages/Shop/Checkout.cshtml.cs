using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FitComrade.Entities;
using FitComrade.Models;
using FitComrade.Helpers;

namespace FitComrade.Pages.Shop
{
    public class CheckoutModel : PageModel
    {
        private readonly FitComrade.Data.FitComradeContext _context;

        public CheckoutModel(FitComrade.Data.FitComradeContext context)
        {
            _context = context;
        }

        public List<Item> cart { get; set; }
        public decimal Total { get; set; }

        [BindProperty]
        public Order Order { get; set; }

        public void OnGet()
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            Total = cart.Sum(i => i.Products.SellPrice * i.Quantity);
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Order.Items = cart;
            Order.TotalPrice = Total;
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}
