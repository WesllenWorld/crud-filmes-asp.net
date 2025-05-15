using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilmes2025.Model;

namespace RazorPagesFilmes2025.Data
{
    public class RazorPagesFilmes2025Context : DbContext
    {
        public RazorPagesFilmes2025Context (DbContextOptions<RazorPagesFilmes2025Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesFilmes2025.Model.Filme> Filme { get; set; } = default!;
    }
}
