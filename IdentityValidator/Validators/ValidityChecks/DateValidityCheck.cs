using System.Globalization;
namespace IdentityValidator.Validators.ValidityChecks
{
    public class DateValidityCheck : IValidityCheck
    {
        public string ErrorMessage { get; private set; } = string.Empty;

        public bool Validate(string number)
        {
            string datePart = number[..6];

            if (DateTime.TryParseExact(datePart, "yyMMdd", null, DateTimeStyles.None, out _))
            {
                return true;
            }
            else
            {
                ErrorMessage = "Invalid date.";
                return false;
            }
        }
    }
}