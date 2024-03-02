using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeliculaCrudRazor.Models;

namespace PeliculaCrudRazor.Data
{
    public class PeliculaCrudRazorContext : DbContext
    {
        public PeliculaCrudRazorContext (DbContextOptions<PeliculaCrudRazorContext> options)
            : base(options)
        {
        }

        public DbSet<PeliculaCrudRazor.Models.Peliculas> Peliculas { get; set; } = default!;
    }
}
