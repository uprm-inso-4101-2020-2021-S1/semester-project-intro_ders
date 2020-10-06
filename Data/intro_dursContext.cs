using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using intro_durs.Models;

namespace intro_durs.Data
{
    public class intro_dursContext : DbContext
    {
        public intro_dursContext (DbContextOptions<intro_dursContext> options)
            : base(options)
        {
        }

        public DbSet<intro_durs.Models.Form> Form { get; set; }
    }
}
