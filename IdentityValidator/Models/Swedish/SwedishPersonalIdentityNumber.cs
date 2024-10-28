using IdentityValidator.Validators.ValidityChecks;

namespace IdentityValidator.Models.Swedish
{
    public class SwedishPersonalIdentityNumber(string number) : IdentityNumber(number, new[] { 10, 12 })
    {
        public override bool IsValid()
        {
            List<IValidityCheck> checks =
            [
            new DateValidityCheck(),
            new LuhnValidityCheck()
            ];

            foreach (var check in checks)
            {
                if (!check.Validate(Number))
                {
                    Console.WriteLine($"Validation Failed: {check.ErrorMessage}");
                    return false;
                }
            }

            return true;
        }
    }
}