using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JoaoTest.Data;
using JoaoTest.Models;

namespace JoaoTest.Pages_Estudantes
{
    public class CreateModel : PageModel
    {
        private readonly JoaoTest.Data.ApplicationDbContext _context;

        public CreateModel(JoaoTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Estudante Estudante { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Estudantes == null || Estudante == null)
            {
                return Page();
            }

            _context.Estudantes.Add(Estudante);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
