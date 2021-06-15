using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie11.Data;
using RazorPagesMovie11.Models;

namespace RazorPagesMovie11.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie11.Data.RazorPagesMovie11Context _context;

        public IndexModel(RazorPagesMovie11.Data.RazorPagesMovie11Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
