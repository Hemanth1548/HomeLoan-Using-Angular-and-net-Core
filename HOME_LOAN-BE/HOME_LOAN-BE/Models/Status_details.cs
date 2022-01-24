using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Models
{
    public class Status_details
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int statusid { get; set; }
        public string status { get; set; }
        public float amount { get; set; }
        [ForeignKey("Property_id")]
        public int Propertyid { get; set; }

    }
}
