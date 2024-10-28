using IdentityValidator.Models;

namespace IdentityValidator.Validators
{
    public static class NumberValidator
    {
        public static void Validate(IdentityNumber number)
        {
            string result = number.IsValid()
                ? $"The number: {number} is valid."
                : $"The number: {number} is invalid.";
            Console.WriteLine(result);
        }
    }
}