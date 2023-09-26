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
    public class IndexModel : PageModel
    {
        private readonly JoaoTest.Data.ApplicationDbContext _context;

        public IndexModel(JoaoTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Estudante> Estudante { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Estudantes != null)
            {
                Estudante = await _context.Estudantes.ToListAsync();
            }
        }
    }
}
