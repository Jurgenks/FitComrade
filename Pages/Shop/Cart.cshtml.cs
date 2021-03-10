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
    public class CartModel : PageModel
    {
        private readonly FitComrade.Data.FitComradeContext _context;

        public CartModel(FitComrade.Data.FitComradeContext context)
        {
            _context = context;
        }

        public List<Item> cart { get; set; }
        public decimal Total { get; set; }

        public void OnGet()
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            Total = cart.Sum(i => i.Products.SellPrice * i.Quantity);
        }

        public IActionResult OnGetBuyNow(int id)
        {
            var productModel = new ProductModel(_context);
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart == null)
            {
                cart = new List<Item>();
                cart.Add(new Item
                {
                    Products = productModel.find(id),
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                int index = Exists(cart, id);
                if (index == -1)
                {
                    cart.Add(new Item
                    {
                        Products = productModel.find(id),
                        Quantity = 1
                    });
                }
                else
                {
                    cart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToPage("Cart");
        }

        public IActionResult OnGetDelete(int id)
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = Exists(cart, id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("Cart");
        }

        public IActionResult OnPostUpdate(int[] quantities)
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (var i = 0; i < cart.Count; i++)
            {
                cart[i].Quantity = quantities[i];
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("Cart");
        }

        private int Exists(List<Item> cart, int id)
        {
            for (var i = 0; i < cart.Count; i++)
            {
                if (cart[i].Products.ID == id)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
