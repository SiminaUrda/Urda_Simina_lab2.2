﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Urda_Simina_lab2._2.Data;
using Urda_Simina_lab2._2.Models;

namespace Urda_Simina_lab2._2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Urda_Simina_lab2._2.Data.Urda_Simina_lab2_2Context _context;

        public IndexModel(Urda_Simina_lab2._2.Data.Urda_Simina_lab2_2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
