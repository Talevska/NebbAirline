using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Validators
{
    public class AllLettersValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return ((string)value).All(Char.IsLetter);
        }
    }
}
