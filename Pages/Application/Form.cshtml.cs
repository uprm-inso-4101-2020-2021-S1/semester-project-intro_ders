using intro_durs.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intro_durs.Pages.Application
{
    public class FormModel : PageModel
    {
        private readonly FirstContext _context;

        public FormModel(FirstContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<tblStudentProgram> tblStudentProgram { get; set; }

        [BindProperty]
        public List<tblForm> tblForm { get; set; }

        [BindProperty]
        public string inputNAMESelection { get; set; }

        [BindProperty]
        public string inputINICIALSelection { get; set; }

        [BindProperty]
        public string inputAPELLIDOSelection { get; set; }

        [BindProperty]
        public string inputAPELLIDO2Selection { get; set; }

        [BindProperty]
        public string activeOrInactiveSelection { get; set; }

        [BindProperty]
        public string programaDeEstudioSelection { get; set; }




        public async Task<IActionResult> OnGetTestPast(int studentID)
        {
            ViewData["studentID"] = studentID.ToString();

           tblStudentProgram = await _context.tblStudentProgram
                .OrderBy(o => o.strProgram)
                .ToListAsync();

            ViewData["TblProgramaDeEstudio"] = new SelectList(tblStudentProgram, "strProgram", "strProgram");


            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {


            tblForm FormTable = new tblForm();

            string FullName = inputNAMESelection + " " + inputINICIALSelection + " " + inputAPELLIDOSelection + " " + inputAPELLIDO2Selection;


            FormTable.strFullName = FullName;
            FormTable.strActiveOrInactive = activeOrInactiveSelection;
            FormTable.strStudentProgram = programaDeEstudioSelection;

           _context.insertDataForm(FormTable);


            await _context.SaveChangesAsync();

            return RedirectToPage("/Application/HomePage");

        }
    }
}
