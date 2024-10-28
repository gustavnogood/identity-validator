namespace IdentityValidator.Validators.ValidityChecks
{

    public class LuhnValidityCheck : IValidityCheck
    {
        public string ErrorMessage { get; private set; } = string.Empty;

        public bool Validate(string number)
        {
            if (ValidityLogic.LuhnValidator.IsValid(number))
            {
                return true;
            }
            else
            {
                ErrorMessage = "Controlnumber is invalid according to Luhn-algoritm.";
                return false;
            }
        }
    }
}