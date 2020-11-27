using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace intro_durs.Pages.Application
{
    public class registerFormModel : PageModel
    {
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string button)
        {

           if (button == "SometerCopiaDiploma")
            {

                return RedirectToPage("/Application/CopiaDeDiplomaReportados");

            }


          if (button == "SometerDiferimiento")
            {

                return RedirectToPage("/Application/DiferimientoReportados.cshtml");

            }

          if (button == "SometerPlanilla")
            {

                return RedirectToPage("/Application/PlanillaContribucionReportados");

            }



            return RedirectToPage("/Application/loginPage");

        }


    }
}
