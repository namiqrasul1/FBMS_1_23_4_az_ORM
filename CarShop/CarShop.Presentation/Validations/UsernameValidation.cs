using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace CarShop.Presentation.Validations;

public class UsernameValidation : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        var regex = new Regex(@"^[a-zA-Z0-9_]{3,16}$");
        var text = value.ToString();
        if (!regex.IsMatch(text))
            return new ValidationResult(false, "Write valid username{username1}");
        else
            return ValidationResult.ValidResult;
    }
}
