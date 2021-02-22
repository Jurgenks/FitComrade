using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FitComrade.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }
        public string Country { get; set; }
        public decimal Weight { get; set; }
    }
}
