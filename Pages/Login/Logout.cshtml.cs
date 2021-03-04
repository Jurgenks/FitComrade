using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FitComrade.Pages.Login
{
    public class LogoutModel : PageModel
    {

        public IActionResult OnPost()
        {
            LoginAccountModel.SignedIn = false;
            LoginAccountModel.account = null;

            return RedirectToPage("/Login/Index");
        }
        public void OnGet()
        {
            
        }
    }
}
