using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using intro_durs.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace intro_durs.Pages.Application
{
    public class loginPage : PageModel
    {

        private readonly FirstContext _context;
        public loginPage(FirstContext context)
        {
            _context = context;
        }


        [BindProperty]
        public int idNumberInput { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var resultIDNumber = _context.getIDNumber(idNumberInput).Result;
            var resultIDType = _context.getIDType(idNumberInput).Result;




            if (resultIDNumber[0].countUSER != 0)  //check if the user exist in the database
            {
                if (resultIDType[0].typeCount != 0)   //check if is an student
                {
                    return RedirectToPage("/Application/HomePage");

                }

                return RedirectToPage("/Application/loginPage");


            }


                return RedirectToPage("/Application/loginPage");
        }
    }
}
