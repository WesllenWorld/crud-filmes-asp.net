using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesFilmes2025.Data;
using RazorPagesFilmes2025.Model;

namespace RazorPagesFilmes2025.Pages.Filmes
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesFilmes2025.Data.RazorPagesFilmes2025Context _context;

        public CreateModel(RazorPagesFilmes2025.Data.RazorPagesFilmes2025Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Filme Filme { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Filme.Add(Filme);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
