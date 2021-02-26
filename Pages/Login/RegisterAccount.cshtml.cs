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
    public class RegisterAccountModel : PageModel
    {
        private readonly FitComrade.Data.FitComradeContext _context;

        public RegisterAccountModel(FitComrade.Data.FitComradeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RegisterModel RegisterModel { get; set; }
        

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var data = _context.RegisterModel.Where(s => s.UserName.Equals(RegisterModel.UserName) || s.Email.Equals(RegisterModel.Email)).ToList();
            if(data.Count() > 0)
            {
                return Page();
            }

            _context.RegisterModel.Add(RegisterModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./LoginAccount");
        }
    }
}
