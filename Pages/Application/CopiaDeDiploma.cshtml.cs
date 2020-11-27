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
    public class CopiaDeDiploma : PageModel
    {
        private readonly FirstContext _context;

        public CopiaDeDiploma(FirstContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<tblStudentProgram> tblStudentProgram { get; set; }


        [BindProperty]
        public List<tblCopiaDeDiploma> tblCopiaDeDiploma { get; set; } 


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
        public string inputDegreeSelection { get; set; }

        [BindProperty]
        public string inputGradYearSelection { get; set; }

        [BindProperty]
        public string programaDeEstudioSelection { get; set; }

        [BindProperty]
        public string inputSignatureSelection { get; set; }

        [BindProperty]
        public DateTime inputDateSelection { get; set; }
        





        public async Task<IActionResult> OnGet()
        {

            tblStudentProgram = await _context.tblStudentProgram
                 .OrderBy(o => o.strProgram)
                 .ToListAsync();

            ViewData["TblProgramaDeEstudio"] = new SelectList(tblStudentProgram, "strProgram", "strProgram");


            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {


            tblCopiaDeDiploma FormTable = new tblCopiaDeDiploma();

            string FullName = inputNAMESelection + " " + inputINICIALSelection + " " + inputAPELLIDOSelection + " " + inputAPELLIDO2Selection;


            FormTable.strFullName = FullName;
            FormTable.strEmail = inputEmailSelection;
            FormTable.strPhone = inputPhoneSelection; 
            FormTable.strDegree = inputDegreeSelection;          
            FormTable.strGradYear = inputGradYearSelection;
            FormTable.strStudentProgram = programaDeEstudioSelection;
            FormTable.strSignature = inputSignatureSelection;
            FormTable.date = inputDateSelection;

            _context.insertDataCopiaDeDiploma(FormTable);


            await _context.SaveChangesAsync();

            return RedirectToPage("/Application/HomePage");

        }

    }
}
