using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE
{
    public class Customer_Details
    {
        
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Customer_id { get; set; }
       // [Required, MaxLength(50), RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Only letters of the alphabet")]
        //[Display(Name = "First Name")]
        public string First_Name { get; set; }
       // [MaxLength(50), RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Only letters of the alphabet")]
       // [Display(Name = "Middle Name")]
        public string Middle_Name { get; set; }
      //  [MaxLength(50), RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Only letters of the alphabet")]
       // [Display(Name = "Last Name")]
        public string Last_Name { get; set; }
       // [Required(ErrorMessage = "Please enter your email address")]
        //[DataType(DataType.EmailAddress)]
        //[Display(Name = "Email address")]
        //[MaxLength(50)]
        //[RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email_id { get; set; }
       // [Required(ErrorMessage = "Password is required")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
       // [Required(ErrorMessage = "Confirm Password is required")]
      //  [DataType(DataType.Password)]
       // [Compare("Password")]
        public string Confirm_Password { get; set; }
       // [Display(Name = "Mobile Number:")]
       // [Required(ErrorMessage = "Mobile Number is required.")]
      //  [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Phone_No { get; set; }
       // [DataType(DataType.Date)]
       // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
      //  [RegularExpression(@"^(\d{12})$", ErrorMessage = "error Message")]
       // [Display(Name = "Aadhar Number")]
        public string Aadhar_No { get; set; }
        //[Display(Name = "PAN Card:")]
      //  [Required(ErrorMessage = "PAN Number is required")]
      //  [RegularExpression("^([A-Za-z]){5}([0-9]){4}([A-Za-z]){1}$", ErrorMessage = "Invalid PAN Number")]
        public string Pan_No { get; set; }
        public string Squestion { get; set; }
        public string Answer { get; set; }
        [ForeignKey("Property_id")]
        public int Propertyid { get; set; }
        //[ForeignKey("Property_id")]
        //public Property_Details property_Details { get; set; }
        //public virtual List<Property_Details> Property_Detail { get; set; }


    }
}
