using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intro_durs.Pages.Models
{
    public class tblDiferimiento
    {
        public int ID { get; set; }
        public string strFullName { get; set; }
        public string strEmail { get; set; }
        public string strPhone { get; set; }
        public string strCredits { get; set; }
        public DateTime gradYear { get; set; }
        public string strSemesters { get; set; }
        public string strActiveOrInactive { get; set; }
        public string strStudentProgram { get; set; }
        public string strSignature { get; set; }
        public DateTime date { get; set; }
    }
}
