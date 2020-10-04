using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Validators
{
    public class DepartureDateValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //  Departure date and time must be later than DateTime.Now
            if (DateTime.Compare((DateTime)value, DateTime.UtcNow) <= 0)
            {
                return new ValidationResult("This passenger is too young to book this flight");
            }
            // Departure Date must be at least 7 days after birth date
            Ticket ticket = (Ticket)validationContext.ObjectInstance;
            TimeSpan interval = (DateTime)value - ticket.DateBirth;
            if (interval.Days < 7)
            {
                return new ValidationResult("Departure must be at least 7 days after birth date");
            }
            return ValidationResult.Success;
        }
    }
}
