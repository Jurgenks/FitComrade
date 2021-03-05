using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FitComrade.Data;
using FitComrade.Models;
using Microsoft.EntityFrameworkCore;

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

        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                
                return Page();
            }

            var attempt = _context.LogOnModel.Where(s => s.UserName.Equals(LogOnModel.UserName)).ToList();
            
            var data = _context.RegisterModel.Where(s => s.UserName.Equals(LogOnModel.UserName) && s.Password.Equals(LogOnModel.Password)).ToList();

            if (data.Count() > 0)
            {
                if(attempt.Count() == 0)
                {
                    LogOnModel.Password = "****";
                    _context.Add(LogOnModel);
                    await _context.SaveChangesAsync();
                }
                SignedIn = true;
                account = LogOnModel.UserName;
                return RedirectToPage("/Account/Index");
            }
            else if(attempt.Count() > 0)
            {
                LogOnModel.FailedLogin = true;
                _context.Add(LogOnModel);

            }

            
            await _context.SaveChangesAsync();

            return Page();

        }
        
    }
}
