using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FitComrade.Models;

namespace FitComrade.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly FitComrade.Data.FitComradeContext _context;

        public IndexModel(FitComrade.Data.FitComradeContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }
    }
}
