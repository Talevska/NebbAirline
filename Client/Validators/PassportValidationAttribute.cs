using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Validators
{
    public class PassportValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            // ex. Passport(B1234567)
            // First char of passport string must be letter 
            if (!char.IsLetter(((string)value)[0]))
            {
                return false;
            }
            // Other 7 chars must be digits
            for (int i = 1; i < ((string)value).Length; i++)
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
