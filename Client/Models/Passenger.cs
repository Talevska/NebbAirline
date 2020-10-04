using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Client.Validators;

namespace Client.Models
{
    public class Passenger
    {
        public int PassengerID { get; set; }

        [Display(Name = "First Name:")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "[3-12] characters")]
        [AllLettersValidation(ErrorMessage = "Only letters")]
        [Required(ErrorMessage = "Please enter First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name:")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "[3-15] characters")]
        [AllLettersValidation(ErrorMessage = "Only letters")]
        [Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth:")]
        [ValidDateValidation(ErrorMessage = "Invalid date")]
        [Required(ErrorMessage = "Please enter Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateBirth { get; set; }

        [Display(Name = "Passport #:")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Passport must contain exactly 8 characters")]
        [PassportValidation(ErrorMessage ="ex. B1234567")]
        [Required(ErrorMessage = "Please enter Passport #")]
        public string Passport { get; set; }
    }
}
