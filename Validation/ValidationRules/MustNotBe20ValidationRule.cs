using System.Globalization;
using System.Windows.Controls;

namespace Validation.ValidationRules
{
    public class MustNotBe20ValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is string s && int.TryParse(s, out int i) && i == 20)
                return new ValidationResult(false, "Must not be 20!");

            return ValidationResult.ValidResult;
        }
    }
}
