using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilmes2025.Data;
using RazorPagesFilmes2025.Model;

namespace RazorPagesFilmes2025.Pages.Filmes
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesFilmes2025.Data.RazorPagesFilmes2025Context _context;

        public DetailsModel(RazorPagesFilmes2025.Data.RazorPagesFilmes2025Context context)
        {
            _context = context;
        }

        public Filme Filme { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filme = await _context.Filme.FirstOrDefaultAsync(m => m.ID == id);
            if (filme == null)
            {
                return NotFound();
            }
            else
            {
                Filme = filme;
            }
            return Page();
        }
    }
}
