using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Display(Name= "Employee ID")]
        [Range(100000,999999,ErrorMessage = "you need a valid EmployeeID")]
        public int EmployeeId { get; set; }


        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please Enter First Name.")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please Enter Last Name.")]
        public string  LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please Enter Email Address.")]
        public string EmailAddress { get; set; }


        [Display(Name = "Conform Email")]
        [Compare("EmailAddress",ErrorMessage = "the email and conform email must match.")]
        public string ConformEmail{ get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "you must have a password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "you need to provide a long enough  password.")]
        public string Password { get; set; }


        [Display(Name = "Conform Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "your password and conform password do not match.")]
        public string ConformPassword { get; set; }
    }
}