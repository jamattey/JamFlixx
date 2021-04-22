using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JamFlixx.Data;
using RazorPageMovie.Models;

namespace JamFlixx.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly JamFlixx.Data.JamFlixxContext _context;

        public IndexModel(JamFlixx.Data.JamFlixxContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        // The BindProperty binds foreign values and query strings of the same name to the searchstring property
        
        [BindProperty(SupportsGet = true)]

        // supportGet attribute is responsible for binding on get requests.

        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
