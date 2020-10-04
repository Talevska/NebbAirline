using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Server.Validators;

namespace Server.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }

        // Passenger Info
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
        [Required(ErrorMessage = "Please enter Date of Birth")]
        [DataType(DataType.Date)]
        [ValidDateValidation(ErrorMessage = "Invalid Date of Birth")]
        public DateTime DateBirth { get; set; }

        [Display(Name = "Passport #:")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Passport # must contain exactly 8 characters")]
        [PassportValidation(ErrorMessage = "ex. B1234567")]
        [Required(ErrorMessage = "Please enter Passport #")]
        public string Passport { get; set; }

        // Flight Info
        [Display(Name = "Flight Code #:")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Flight Code must contain exactly 6 characters")]
        [FlightCodeValidation(ErrorMessage = "ex. SK1234")]
        [Required(ErrorMessage = "Please enter Flight Code #")]
        public string FlightCode { get; set; }

        [Display(Name = "Origin:")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "[3-15] characters")]
        [AllLettersValidation(ErrorMessage = "Only letters")]
        [Required(ErrorMessage = "Please enter Origin")]
        public string Origin { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "[3-15] characters")]
        [AllLettersValidation(ErrorMessage = "Only letters")]
        [Display(Name = "Destination:")]
        [Required(ErrorMessage = "Please enter Destination")]
        public string Destination { get; set; }

        [Display(Name = "Departure:")]
        [DepartureDateValidation]
        [Required(ErrorMessage = "Please enter Departure date and time")]
        [DataType(DataType.DateTime)]
        public DateTime Departure { get; set; }

        [Display(Name = "Return:")]
        [DataType(DataType.DateTime)]
        [ReturnDateValidation]
        public DateTime? Return { get; set; }

        [Range(0, 3, ErrorMessage = "Minimum 0 and maximum 3")]
        [Display(Name = "Free carry-on bag #:")]
        [Required(ErrorMessage = "Please enter number of Carry-on bag/s")]
        public int CarryOnBag { get; set; }

        [Range(0, 3, ErrorMessage = "Minimum 0, and maximum 3")]
        [Display(Name = "Trolley bag #:")]
        [Required(ErrorMessage = "Please enter number of Trolley bag/s")]
        public int TrolleyBag { get; set; }

        [Range(0, 3, ErrorMessage = "Minimum 0, and maximum 3")]
        [Display(Name = "Checked-in bag #:")]
        [Required(ErrorMessage = "Please enter number of Checked-in bag/s")]
        public int CheckedInBag { get; set; }
    }
}
