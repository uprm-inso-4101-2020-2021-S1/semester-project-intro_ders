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

        public virtual DbSet<tblPlanillaContribucion> tblPlanillaContribucion { get; set; }

        public virtual DbSet<tblCopiaDeDiploma> tblCopiaDeDiploma { get; set; }

        public virtual DbSet<tblDiferimiento> tblDiferimiento { get; set; }

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


        /* STORE PROCEDURES */
        /*public DbQuery<spLoginPage> spLoginPage { get; set; }

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
        */
        public DbQuery<spCopiaDeDiploma> spCopiaDeDiploma { get; set; }

        public async Task<List<spCopiaDeDiploma>> getCopiaDeDiplomaReports()
        {

            var query = @"
                DECLARE @RC int
                EXECUTE @RC = spCopiaDeDiploma";

            var result = await spCopiaDeDiploma.FromSqlRaw(query).ToListAsync();

            return result;
        }

        public Boolean insertDataPlanillaContribucion(tblPlanillaContribucion tbl)
        {


            if (!tbl.Equals(null))
            {
                this.Add(tbl);
                this.SaveChanges();
                return true;
            }


            return false;
        }

        public Boolean insertDataCopiaDeDiploma(tblCopiaDeDiploma tbl)
        {


            if (!tbl.Equals(null))
            {
                this.Add(tbl);
                this.SaveChanges();
                return true;
            }


            return false;
        }


        public Boolean insertDataDiferimiento(tblDiferimiento tbl)
        {


            if (!tbl.Equals(null))
            {
                this.Add(tbl);
                this.SaveChanges();
                return true;
            }


            return false;
        }


    }


}
