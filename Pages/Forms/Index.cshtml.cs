using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using intro_durs.Data;
using intro_durs.Models;

namespace intro_durs.Pages.Forms
{
    public class IndexModel : PageModel
    {
        private readonly intro_durs.Data.intro_dursContext _context;

        public IndexModel(intro_durs.Data.intro_dursContext context)
        {
            _context = context;
        }

        public IList<Form> Form { get;set; }

        public async Task OnGetAsync()
        {
            Form = await _context.Form.ToListAsync();
        }
    }
}
