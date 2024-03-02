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
    public class IndexModel : PageModel
    {
        private readonly CRUDRAZOR.Data.CRUDRAZORContext _context;

        public IndexModel(CRUDRAZOR.Data.CRUDRAZORContext context)
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
