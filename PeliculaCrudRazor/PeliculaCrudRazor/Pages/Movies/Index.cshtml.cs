using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PeliculaCrudRazor.Data;
using PeliculaCrudRazor.Models;

namespace PeliculaCrudRazor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly PeliculaCrudRazor.Data.PeliculaCrudRazorContext _context;

        public IndexModel(PeliculaCrudRazor.Data.PeliculaCrudRazorContext context)
        {
            _context = context;
        }

        public IList<Peliculas> Peliculas { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Peliculas != null)
            {
                Peliculas = await _context.Peliculas.ToListAsync();
            }
        }
    }
}
