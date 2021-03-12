using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitComrade.Entities;
using FitComrade.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FitComrade.Pages.Login
{
    public class LogoutModel : PageModel
    {

        public IActionResult OnPost()
        {

            SessionHelper.myUser.Status = false;
            return RedirectToPage("/Login/Index");
        }
        public void OnGet()
        {
            SessionHelper.GetSession(HttpContext.Session);
        }
    }
}
