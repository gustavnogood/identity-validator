namespace IdentityValidator.Validators.ValidityChecks
{
    public interface IValidityCheck
    {
        bool Validate(string number);
        string ErrorMessage { get; }
    }
}