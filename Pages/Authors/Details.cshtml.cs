using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Urda_Simina_lab2._2.Data;
using Urda_Simina_lab2._2.Models;

namespace Urda_Simina_lab2._2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Urda_Simina_lab2._2.Data.Urda_Simina_lab2_2Context _context;

        public DetailsModel(Urda_Simina_lab2._2.Data.Urda_Simina_lab2_2Context context)
        {
            _context = context;
        }

      public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.Id == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }
    }
}
