using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace intro_durs.Pages
{
    public class IndexModel : PageModel
    {
        public RedirectResult OnGet()
        {
            return Redirect("/Application/HomePage");
        }

    }
}
