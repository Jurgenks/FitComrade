using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FitComrade.Data;
using FitComrade.Models;
using FitComrade.Helpers;

namespace FitComrade.Pages.Account.Orders
{
    public class IndexModel : PageModel
    {
        private readonly FitComrade.Data.FitComradeContext _context;

        public IndexModel(FitComrade.Data.FitComradeContext context)
        {
            _context = context;
        }

        public List<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            var data = _context.Orders.Where(m => m.Username.Equals(SessionHelper.myUser.UserName));
            if (data.Count() > 0 && SessionHelper.myUser.UserName != null)
            {
                Order = await data.ToListAsync();
            }
            else
            {
                RedirectToPage("Account/Index");
            }
            
        }
    }
}
