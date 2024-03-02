using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PeliculaCrudRazor.Data;
using PeliculaCrudRazor.Models;

namespace PeliculaCrudRazor.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly PeliculaCrudRazor.Data.PeliculaCrudRazorContext _context;

        public CreateModel(PeliculaCrudRazor.Data.PeliculaCrudRazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Peliculas Peliculas { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Peliculas.Add(Peliculas);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
