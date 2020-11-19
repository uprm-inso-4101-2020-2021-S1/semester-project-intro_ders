using intro_durs.Pages.Models;
using Microsoft.Data.SqlClient;
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


        /* STORE PROCEDURES */
        public DbQuery<spLoginPage> spLoginPage { get; set; }

        public async Task<List<spLoginPage>> getIDNumber(int intID)
        {

            var query = @"
                DECLARE @RC int

                EXECUTE @RC = spLoginPage 
                  @idNumber";

            var result = await spLoginPage.FromSqlRaw(query, new SqlParameter("@idNumber", intID)).ToListAsync();

            return result;
        }




        public DbQuery<spUserType> spUserType { get; set; }

        public async Task<List<spUserType>> getIDType(int intID)
        {

            var query = @"
                DECLARE @RC int

                EXECUTE @RC = spUserType 
                  @IDNumber";

            var result = await spUserType.FromSqlRaw(query, new SqlParameter("@IDNumber", intID)).ToListAsync();

            return result;
        }


    }
}
