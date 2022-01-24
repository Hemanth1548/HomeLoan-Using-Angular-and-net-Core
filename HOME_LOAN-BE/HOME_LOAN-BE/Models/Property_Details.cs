
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE
{
    public class Property_Details
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Propertyid { get; set; }
        public string PropertyLocation { get; set; }
        public string PropertyName { get; set; }
        public int EstimatedAmount { get; set; }
      
        //[ForeignKey("Customer_Details")]
        //[Key]
        //public int Customer_id { get; set; }
        // public virtual Customer_Details Customer_Detail { get; set; }

    }
}
