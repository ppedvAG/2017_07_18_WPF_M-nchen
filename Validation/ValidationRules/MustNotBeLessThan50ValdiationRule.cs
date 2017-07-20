using System;
using System.Globalization;
using System.Windows.Controls;

namespace Validation.ValidationRules
{
    public class MustNotBeLessThan50ValdiationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is string s && int.TryParse(s, out int i) && i < 50)
                return new ValidationResult(false, "Must not be less than 50!");

            return ValidationResult.ValidResult;
        }
    }
}
