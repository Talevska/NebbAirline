using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Server.Models;

namespace Server.Validators
{
    public class ValidDateValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            //  Birth date must be before DateTime.Now
            if (DateTime.Compare((DateTime)value, DateTime.UtcNow.Date) >= 0)
            {
                return false;
            }
            return true;
        }
    }
}
