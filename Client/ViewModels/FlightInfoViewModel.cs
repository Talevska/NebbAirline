using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Client.Validators;
using Client.Models;

namespace Client.ViewModels
{
    public class FlightInfoViewModel
    {
        public int FlightID { get; set; }

        [Display(Name = "Flight Code #:")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Flight Code # must contain exactly 6 characters")]
        [FlightCodeValidation(ErrorMessage = "ex. SK1234")]
        [Required(ErrorMessage = "Please enter Flight Code #")]
        public string FlightCode { get; set; }

        [Display(Name = "Origin:")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "[3-15] characters")]
        [AllLettersValidation(ErrorMessage = "Only letters")]
        [Required(ErrorMessage = "Please enter Origin")]
        public string Origin { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "[3-15] characters")]
        [Display(Name = "Destination:")]
        [AllLettersValidation(ErrorMessage = "Only letters")]
        [Required(ErrorMessage = "Please enter Destination")]
        public string Destination { get; set; }

        [Display(Name = "Departure:")]
        [Required(ErrorMessage = "Please enter Departure date and time")]
        [ValidDateValidation(ErrorMessage = "Invalid Date of Departure")]
        [DataType(DataType.DateTime)]
        public DateTime Departure { get; set; }
        public List<Passenger> Passengers { get; set; }

        public FlightInfoViewModel(Flight flight, IEnumerable<Passenger> passengers)
        {
            FlightID = flight.FlightID;
            FlightCode = flight.FlightCode;
            Origin = flight.Origin;
            Destination = flight.Destination;
            Departure = flight.Departure;

            Passengers = passengers.ToList();
        }
    }
}
