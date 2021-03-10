using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FitComrade.Data;
using FitComrade.Models;
using FitComrade.Pages.Login;
using FitComrade.Entities;
using FitComrade.Helpers;

namespace FitComrade.Pages.Account.ProductManager
{
    public class IndexModel : PageModel
    {
        private readonly FitComrade.Data.FitComradeContext _context;

        public IndexModel(FitComrade.Data.FitComradeContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; }
        private string[] admins = { "Jurgen" };

        public async Task OnGetAsync()
        {
            bool acces = false;
            for(int i = 0; i < admins.Length; i++)
            {
                if(SessionHelper.myUser.UserName == admins[i])
                {
                    acces = true;
                }
                
            }
            if (acces == true)
            {
                Products = await _context.Products.ToListAsync();
            }
            else
            {
                RedirectToPage("./Index");
            }
            
            
            
        }
        
    }
}
