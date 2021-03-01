using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FitComrade.Data;
using FitComrade.Models;

namespace FitComrade.Pages.Login
{
    public class LoginAccountModel : PageModel
    {
        private readonly FitComrade.Data.FitComradeContext _context;

        public LoginAccountModel(FitComrade.Data.FitComradeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public LogOnModel LogOnModel { get; set; }
        public static bool SignedIn = false;
        public static string account;
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            var data = _context.RegisterModel.Where(s => s.UserName.Equals(LogOnModel.UserName) && s.Password.Equals(LogOnModel.Password)).ToList();
            if (data.Count() > 0)
            {
                SignedIn = true;
                account = LogOnModel.UserName;
                return RedirectToPage("/Account/Index");
            }

            await _context.DisposeAsync();

            return Page();

        }
    }
}
