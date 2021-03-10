using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FitComrade.Models;
using FitComrade.Entities;
using FitComrade.Helpers;

namespace FitComrade.Pages.Login
{
    public class LoginAccountModel : PageModel
    {
        private readonly FitComrade.Data.FitComradeContext _context;
        
        public LoginAccountModel(FitComrade.Data.FitComradeContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            SessionHelper.GetSession(HttpContext.Session);
        }

        [BindProperty]
        public LogOnModel LogOnModel { get; set; }
        
        

        
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
                if(attempt.Count() == 0) // First succes Login
                {
                    LogOnModel.Password = "****";
                    _context.Add(LogOnModel);
                    SessionHelper.myUser.UserName = LogOnModel.UserName;
                    SessionHelper.myUser.Status = true;
                    await _context.SaveChangesAsync();
                }
                if(attempt.Count() > 0) // Succes Login ++
                {
                    SessionHelper.myUser.UserName = LogOnModel.UserName;
                    SessionHelper.myUser.Status = true;
                }
                                                
                return RedirectToPage("/Account/Index");
            }
            else if(attempt.Count() > 0) // Failed Login
            {
                LogOnModel.FailedLogin = true;
                _context.Add(LogOnModel);

            }

            
            await _context.SaveChangesAsync();

            return Page();

        }
        
    }
}
