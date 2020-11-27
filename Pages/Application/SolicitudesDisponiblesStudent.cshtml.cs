using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace intro_durs.Pages.Application
{
    public class formListModel : PageModel
    {
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string button)
        {
            if (button == "SometerCertificacionEstudiante")
            {

                return RedirectToPage("/Application/certificacionEstudiante");

            }
            
            if (button == "SometerCopiaDiploma")
            {

                return RedirectToPage("/Application/CopiaDeDiploma");

            }


              if (button == "SometerDiferimiento")
            {

                return RedirectToPage("/Application/Diferimiento");

            }

              if (button == "SometerPlanilla")
            {

                return RedirectToPage("/Application/planillaContribucion");

            }



            return RedirectToPage("/Application/loginPage");

        }
    }
}
