using IdentityValidator.Validators.ValidityChecks;

namespace IdentityValidator.Models.Swedish
{
    public class SwedishCoordinatonNumber : IdentityNumber
    {
        public SwedishCoordinatonNumber(string number) 
            : base(number, [10, 12])
        {
        }

        public override bool IsValid()
        {
            string cleanNumber = Number.Length == 12 ? Number.Substring(2) : Number;
            int day = int.Parse(cleanNumber.Substring(4, 2)) - 60;

            if (day < 1 || day > 31)
                return false;

            var luhnCheck = new LuhnValidityCheck();
            if (!luhnCheck.Validate(cleanNumber))
            {
                Console.WriteLine($"Validation Failed: {luhnCheck.ErrorMessage}");
                return false;
            }

            return true;
        }
    }
}