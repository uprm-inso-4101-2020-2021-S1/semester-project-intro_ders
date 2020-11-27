using intro_durs.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace intro_durs.Pages.Application
{
    public class DiferimientoReportadosModel : PageModel
    {
        private readonly FirstContext _context;
        public DiferimientoReportadosModel(FirstContext context)
        {
            _context = context;
        }

        [BindProperty]
        public spDiferimiento spDiferimiento { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {



            return RedirectToPage("/Application/loginPage");
        }

        public async Task<IActionResult> OnGetAsync()
        {
            ViewData["TblDiferimiento"] = _context.getDiferimientoReports().Result;





            return Page();
        }
    }
}
