using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using intro_durs.Pages.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace intro_durs.Pages.Application
{
    public class PlanillaContribucionReportadosModel : PageModel
    {
        private readonly FirstContext _context;
        
        public PlanillaContribucionReportadosModel(FirstContext context)
        {
            this._context = context;
        }

        [BindProperty]
        public spPlanillaContribucion spPlanillaContribucion { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {



            return RedirectToPage("/Application/loginPage");
        }



        public async Task<IActionResult> OnGetAsync()
        {
            ViewData["TblPlanillaContribucion"] = _context.getPlanillaContribucionReports().Result;





            return Page();
        }


    }
}
