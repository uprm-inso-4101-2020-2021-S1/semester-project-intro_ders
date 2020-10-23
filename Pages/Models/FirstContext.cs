using intro_durs.Pages.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace intro_durs.Pages.Models
{
    public partial class FirstContext : DbContext
    {
        public FirstContext(DbContextOptions<FirstContext> options) : base(options)
        {

        }
        public virtual DbSet<tblForm> tblForm { get; set; }
        public virtual DbSet<tblStudentProgram> tblStudentProgram { get; set; }

        /* STORE PROCEDURES */
        /* INSERT DATA TABLES*/

        public Boolean insertDataForm(tblForm tblForm)
        {


            if (!tblForm.Equals(null))
            {
                this.Add(tblForm);
                this.SaveChanges();
                return true;
            }


            return false;
        }

    }
}
