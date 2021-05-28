﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebBank.Data;
using WebBank.Models;

namespace WebBank.Pages.Positions
{
    public class DetailsModel : PageModel
    {
        private readonly WebBank.Data.BankContext _context;

        public DetailsModel(WebBank.Data.BankContext context)
        {
            _context = context;
        }

        public Position Position { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position = await _context.Position.FirstOrDefaultAsync(m => m.PosId == id);

            if (Position == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
