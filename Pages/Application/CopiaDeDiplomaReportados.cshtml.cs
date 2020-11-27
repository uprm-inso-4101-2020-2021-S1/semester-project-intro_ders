using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using intro_durs.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace intro_durs.Pages.Application
{
    public class CopiaDeDiplomaReportadosModel : PageModel
    {
        private readonly FirstContext _context;
        public CopiaDeDiplomaReportadosModel(FirstContext context)
        {
            _context = context;
        }

        [BindProperty]
        public spCopiaDeDiploma spCopiaDeDiploma { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {



            return RedirectToPage("/Application/loginPage");
        }



        public async Task<IActionResult> OnGetAsync()
        {
            ViewData["Tbl"] = _context.getCopiaDeDiplomaReports().Result;





            return Page();
        }



    }
}
