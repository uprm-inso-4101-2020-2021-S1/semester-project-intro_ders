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
    public class planillaContribucion : PageModel
    {
        private readonly FirstContext _context;

        public planillaContribucion(FirstContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<tblStudentProgram> tblStudentProgram { get; set; }


        [BindProperty]
        public List<tblPlanillaContribucion> tblPlanillaContribucion { get; set; }


        [BindProperty]
        public string inputNAMESelection { get; set; }

        [BindProperty]
        public string inputINICIALSelection { get; set; }

        [BindProperty]
        public string inputAPELLIDOSelection { get; set; }

        [BindProperty]
        public string inputAPELLIDO2Selection { get; set; }
       
        [BindProperty]
        public string inputEmailSelection { get; set; }
       
        [BindProperty]
        public string inputPhoneSelection { get; set; }

        [BindProperty]
        public string inputSignatureSelection { get; set; }

        [BindProperty]
        public DateTime inputDateSelection { get; set; }



        [BindProperty]
        public string activeOrInactiveSelection { get; set; }

        [BindProperty]
        public string programaDeEstudioSelection { get; set; }




        public async Task<IActionResult> OnGetTestPast()
        {

            tblStudentProgram = await _context.tblStudentProgram
                 .OrderBy(o => o.strProgram)
                 .ToListAsync();

            ViewData["TblProgramaDeEstudio"] = new SelectList(tblStudentProgram, "strProgram", "strProgram");


            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {


            tblPlanillaContribucion FormTable = new tblPlanillaContribucion();

            string FullName = inputNAMESelection + " " + inputINICIALSelection + " " + inputAPELLIDOSelection + " " + inputAPELLIDO2Selection;


            FormTable.strFullName = FullName;
            FormTable.strEmail = inputEmailSelection;
            FormTable.strPhone = inputPhoneSelection;
            FormTable.strSignature = inputSignatureSelection;
            FormTable.Date = inputDateSelection;
            FormTable.strActiveOrInactive = activeOrInactiveSelection;
            FormTable.strStudentProgram = programaDeEstudioSelection;

            _context.insertDataPlanillaContribucion(FormTable);


            await _context.SaveChangesAsync();

            return RedirectToPage("/Application/HomePage");

        }







    }
}
