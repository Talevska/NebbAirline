using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Validators
{
    public class FlightCodeValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            // ex. Flight Code(SK1234)
            // First 2 chars of code string must be letters
            if (!char.IsLetter(((string)value)[0]) || !char.IsLetter(((string)value)[1]))
            {
                return false;
            }

            // Other 4 chars must be digits
            for (int i = 2; i < 6; i++)
            {
                if (!char.IsDigit(((string)value)[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
