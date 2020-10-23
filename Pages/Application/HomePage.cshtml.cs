using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using intro_durs.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace intro_durs.Pages.Application
{
    public class IndexModel : PageModel
    {


        private readonly FirstContext _context;

        public IndexModel(FirstContext context)
        {
            _context = context;
        }

        [BindProperty]
        public int idImput { get; set; }




        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

          return   RedirectToPage("/Application/Form", "TestPast", new { studentID = idImput });


        }
    }
}
