using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JoaoTest.Data;
using JoaoTest.Models;

namespace JoaoTest.Pages_Estudantes
{
    public class DeletarModel : PageModel
    {
        private readonly JoaoTest.Data.ApplicationDbContext _context;

        public DeletarModel(JoaoTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Estudante Estudante { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Estudantes == null)
            {
                return NotFound();
            }

            var estudante = await _context.Estudantes.FirstOrDefaultAsync(m => m.Id == id);

            if (estudante == null)
            {
                return NotFound();
            }
            else 
            {
                Estudante = estudante;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Estudantes == null)
            {
                return NotFound();
            }
            var estudante = await _context.Estudantes.FindAsync(id);

            if (estudante != null)
            {
                Estudante = estudante;
                _context.Estudantes.Remove(Estudante);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
