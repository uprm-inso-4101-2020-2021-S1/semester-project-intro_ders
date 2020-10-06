using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using intro_durs.Data;
using intro_durs.Models;
using Newtonsoft.Json.Serialization;

namespace intro_durs.Pages.Forms
{
    public class CreateModel : PageModel
    {
        private readonly intro_durs.Data.intro_dursContext _context;

        public CreateModel(intro_durs.Data.intro_dursContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Form Form { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Form.Add(Form);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
