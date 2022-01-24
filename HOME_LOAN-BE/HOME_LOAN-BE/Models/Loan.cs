using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE
{
    public class Loan
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Loan_id { get; set; }
        [DataType(DataType.Currency)]
        public float Max_Loan_Amt { get; set; }
        public float ROI { get; set; }
        public int Tenure { get; set; }
        [DataType(DataType.Currency)]
        public float Loan_Amt { get; set; }
        [ForeignKey("Propertyid")]
        public int Propertyid { get; set; }
        //[ForeignKey("Property_id")]
        //public Property_Details property_Details { get; set; }
        //[ForeignKey("Employee_Details")]
        //[Key]
        //public int Emp_ID { get; set; }
        //[ForeignKey("Customer_Details")]
        //[Key]
        // public int Customer_id { get; set; }
        //public virtual Customer_Details Customer_Detail { get; set; }
         // public virtual Property_Details Property_Detail { get; set; }
        // public virtual Employee_Details Employee_Detail { get; set; }
    }
}
