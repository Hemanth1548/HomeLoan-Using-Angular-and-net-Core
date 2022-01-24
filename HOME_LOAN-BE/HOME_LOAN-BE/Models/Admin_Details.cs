using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE
{
    public class Admin_Details
    {
        [Key]
        public string AdminUsername { get; set; }
        public string Password { get; set; }
    }
}
