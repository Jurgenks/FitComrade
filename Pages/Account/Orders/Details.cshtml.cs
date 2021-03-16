using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FitComrade.Data;
using FitComrade.Models;
using FitComrade.Entities;

namespace FitComrade.Pages.Account.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly FitComrade.Data.FitComradeContext _context;

        public DetailsModel(FitComrade.Data.FitComradeContext context)
        {
            _context = context;
        }

        public Order Order;
        public List<OrderDetail> OrderDetail;
        public List<Products> Products;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            OrderDetail = _context.OrderDetails.Where(m => m.OrderID.Equals(id)).ToList();
            Products = _context.Products.ToList();
            Order = await _context.Orders.FirstOrDefaultAsync(m => m.ID == id);
            
            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
