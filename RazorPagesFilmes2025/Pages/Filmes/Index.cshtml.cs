using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilmes2025.Data;
using RazorPagesFilmes2025.Model;

namespace RazorPagesFilmes2025.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesFilmes2025.Data.RazorPagesFilmes2025Context _context;

        public IndexModel(RazorPagesFilmes2025.Data.RazorPagesFilmes2025Context context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get;set; }

        [BindProperty(SupportsGet = true)]
        public string TermoBusca { get; set; }
        [BindProperty(SupportsGet = true)]
        public string TermoGenero {  get; set; }
        public SelectList Generos { get; set; }

        public async Task OnGetAsync()
        {
            var filmes = from f in _context.Filme
                         select f;

            if (!string.IsNullOrWhiteSpace(TermoBusca))
            {
                filmes = filmes.Where(f => f.Titulo.Contains(TermoBusca));
            }
            //Filme = await _context.Filme.ToListAsync();
            if (!string.IsNullOrWhiteSpace(TermoGenero))
            {
                filmes = filmes.Where(f => f.Genero.Equals(TermoGenero));
            }
        

            Generos = new SelectList(await _context.Filme.Select(generoF => generoF.Genero).Distinct().ToListAsync());
            Filme = await filmes.ToListAsync();
        }

        
    }
}
