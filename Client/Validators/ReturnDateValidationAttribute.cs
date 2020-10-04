using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Validators
{
    public class ReturnDateValidationAttribute : ValidationAttribute
    {
        // If return date is chosen it must be at least one day after the departure date
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                //  Return date and time must be later than DateTime.Now
                if (DateTime.Compare((DateTime)value, DateTime.UtcNow) <= 0)
                {
                    return new ValidationResult("Invalid date");
                }

                Ticket ticket = (Ticket)validationContext.ObjectInstance;
                DateTime Return = (DateTime)value;
                TimeSpan interval = Return - ticket.Departure;
                if (interval.Days < 1)
                {
                    return new ValidationResult("Return date must be at least one day after departure date");
                }
            }
            return ValidationResult.Success;
        }
    }
}
