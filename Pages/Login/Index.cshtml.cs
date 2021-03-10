using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitComrade.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FitComrade.Pages.Login
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            SessionHelper.GetSession(HttpContext.Session);
        }
    }
}
