using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace intro_durs.Models
{
    public class Form
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string StudentId { get; set; }

        public string Faculty { get; set; }
        public string Specialty { get; set; }

        public string Degree { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime GradDate { get; set; }


    }


}
