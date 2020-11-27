using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using intro_durs.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace intro_durs.Pages.Application
{
    public class FormPlanillaContribucionReportadosModel : PageModel
    {
        private readonly FirstContext _context;
        public FormPlanillaContribucionReportadosModel(FirstContext context)
        {
            _context = context;
        }

        [BindProperty]
        public sptblForm sptblForm { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {



            return RedirectToPage("/Application/loginPage");
        }



        public async Task<IActionResult> OnGetAsync()
        {
            ViewData["Tbl"] = _context.getTableReports().Result;





            return Page();
        }




    }






}

