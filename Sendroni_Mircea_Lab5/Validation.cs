using System.Globalization;
using System.Windows.Controls;

namespace Sendroni_Mircea_Lab5
{
    //validator pentru camp required
    public class StringNotEmpty : ValidationRule
    {
        //mostenim din clasa ValidationRule
        //suprascriem metoda Validate ce returneaza un
        //ValidationResult
        public override ValidationResult Validate(object value,
        CultureInfo cultureinfo)
        {
            return string.IsNullOrWhiteSpace(value.ToString()) ? new ValidationResult(false, "String cannot be empty") : new ValidationResult(true, null);
        }
    }
    //validator pentru lungime minima a string-ului
    public class StringMinLengthValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureinfo)
        {
            return value.ToString().Length < 3 ? new ValidationResult(false, "String must have at least 3 characters!") : new ValidationResult(true, null);
        }
    }

}