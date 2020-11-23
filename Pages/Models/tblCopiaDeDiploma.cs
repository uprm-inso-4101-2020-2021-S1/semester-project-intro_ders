using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intro_durs.Pages.Models
{
    public class tblCopiaDeDiploma
    {
        public int ID { get; set; }
        public string strFullName { get; set; }
        public string strEmail { get; set; }
        public string strPhone { get; set; }
        public string strDegree { get; set; }
        public string strGradYear { get; set; }
        public string strStudentProgram { get; set; }
        public string strSignature { get; set; }
        public DateTime date { get; set; }
    }
}
