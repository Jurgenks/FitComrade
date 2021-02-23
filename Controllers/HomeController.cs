using FitComrade.Pages;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FitComrade.Models;

namespace FitComrade.Controllers
{
    public class HomeController : Controller
    {
        private readonly Data.FitComradeContext _context;
        public string UserName, Password;
        public HomeController(Data.FitComradeContext context)
        {
            _context = context;
        }
        public IList<Accounts> Accounts { get; set; }

        public async Task OnGetAsync()
        {
            Accounts = await _context.Accounts.ToListAsync();
        }

        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Login(IndexModel model, string returnUrl)
        {
            Accounts acc = new Accounts();
            if (ModelState.IsValid)
            {
                if(acc.UserName == UserName)
                {
                    if(acc.Password == Password)
                    {
                        
                    }
                }
            }

            return View(model);
        }
        [HttpPost]
        public ActionResult Register(IndexModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {

            }

            return View(model);
        }

    }
}
