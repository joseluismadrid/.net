using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDRAZOR.Data;

namespace CRUDRAZOR.Model
{
    public class DetailsModel : PageModel
    {
        private readonly CRUDRAZOR.Data.CRUDRAZORContext _context;

        public DetailsModel(CRUDRAZOR.Data.CRUDRAZORContext context)
        {
            _context = context;
        }

      public Peliculas Peliculas { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Peliculas == null)
            {
                return NotFound();
            }

            var peliculas = await _context.Peliculas.FirstOrDefaultAsync(m => m.Id == id);
            if (peliculas == null)
            {
                return NotFound();
            }
            else 
            {
                Peliculas = peliculas;
            }
            return Page();
        }
    }
}
