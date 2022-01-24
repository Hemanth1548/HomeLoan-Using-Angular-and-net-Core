using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE
{
    public class Employee_Details
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Emp_ID { get; set; }

        public string Type_of_Employment { get; set; }
        [RegularExpression(@"^(\d{2})$", ErrorMessage = "error Message")]
        [Display(Name = "Retirement age")]
        public int Retirement_Age { get; set; }
        public string Organisation_Type { get; set; }
        [Required, MaxLength(50), RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Only letters of the alphabet")]
        [Display(Name = "Employee Name")]
        public string Employee_Name { get; set; }
        [ForeignKey("Property_id")]
        public int Propertyid { get; set; }
        //[ForeignKey("Property_id")]
        //public Property_Details property_Details { get; set; }
        //public virtual Property_Details Property_Detail { get; set; }

    }
}
