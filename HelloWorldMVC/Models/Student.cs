using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelloWorldMVC.Models
{
    public class Student
    {
        [Required]// makes sure there is something there.
        [RegularExpression(@"^\d{9}$", ErrorMessage = "SID must be 9 digits")]
        public string StudentId { get; set; }

        [Required(ErrorMessage = "Give me your name")]// makes sure there is something there.
        [Display(Name ="First Name ")]
        [StringLength(25, ErrorMessage = "This must be 1 to 25 characters")]
        public string FirstName { get; set; }
        
        [Required]// makes sure there is something there.
        [Display(Name = "Last Name ")]
        public string LastName { get; set; }

        // value types such as DateOfBirth are always required because they have to have a value.
        public DateTime DateOfBirth { get; set; }

        //Note: we are not implementing this but this will validate 
        //an email to the fullest.
        [EmailAddress]
        public string EmailAddress { get; set; }



    }
}