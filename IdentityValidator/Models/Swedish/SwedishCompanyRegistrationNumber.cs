using IdentityValidator.Validators.ValidityChecks;

namespace IdentityValidator.Models.Swedish

{
    public class SwedishCompanyRegistrationNumber(string number) : IdentityNumber(number, [10, 12])
    {
        public override bool IsValid()
        {
            var luhnCheck = new LuhnValidityCheck();

            if (Number.Length == 12 && Number.StartsWith("16"))
            {
                string cleanNumber = Number[2..];
                if (!luhnCheck.Validate(cleanNumber))
                {
                    Console.WriteLine($"Validation Failed: {luhnCheck.ErrorMessage}");
                    return false;
                }
            }
            else if (Number.Length == 10)
            {
                if (!luhnCheck.Validate(Number))
                {
                    Console.WriteLine($"Validation Failed: {luhnCheck.ErrorMessage}");
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
    }
}
}