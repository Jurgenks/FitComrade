using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FitComrade.Entities;
using FitComrade.Models;
using FitComrade.Helpers;
using Microsoft.EntityFrameworkCore;

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
        private decimal discount = 1;
        [BindProperty]
        public Order Order { get; set; }
        
        

        public void OnGet()
        {
            cart = SessionHelper.myUser.ShoppingCart;
            decimal itemTotal;
            Total = 0;
            if(cart != null)
            {
                foreach (var item in cart.Where(item => item != null))
                {
                    itemTotal = cart.Sum(i => i.Products.SellPrice * i.Quantity);
                    Total = +itemTotal;
                }
            }
            


        }
        public async Task<IActionResult> OnPostAsync() // Betalen
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            cart = SessionHelper.myUser.ShoppingCart;
            decimal itemTotal;
            Total = 0;
            if (cart != null)
            {
                foreach (var item in cart.Where(item => item != null))
                {
                    itemTotal = cart.Sum(i => i.Products.SellPrice * i.Quantity);
                    Total = +itemTotal;
                }
            }

            Order.Paid = true;  //Fake Payment
            Order.TotalPrice = Total;
            Order.OrderDate = DateTime.Now;
            Order.Username = SessionHelper.myUser.UserName; //Als gebruiker is ingelogd

            
            
            _context.Orders.Add(Order);
            _context.SaveChanges();
            if (Order.Paid == true)
            {
                
                int id = Order.ID;
                if (cart != null)
                {
                    foreach (var item in cart.Where(item => item != null))
                    {
                        _context.OrderDetails.Add(new OrderDetail
                        {
                            OrderID = id,
                            ProductID = item.Products.ID,
                            OrderNumber = _context.Orders.Count(),
                            Price = item.Products.SellPrice,
                            Quantity = item.Quantity,
                            Discount = discount,
                            Total = item.Products.SellPrice * item.Quantity * discount,
                            BillDate = DateTime.Now,
                        });
                        item.Products.Store = item.Products.Store - item.Quantity;
                        _context.Attach(item.Products).State = EntityState.Modified;

                        
                    }
                }

            }

            
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}
