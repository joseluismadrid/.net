using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDRAZOR.Model;

namespace CRUDRAZOR.Data
{
    public class CRUDRAZORContext : DbContext
    {
        public CRUDRAZORContext (DbContextOptions<CRUDRAZORContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDRAZOR.Model.Peliculas> Peliculas { get; set; } = default!;
    }
}
