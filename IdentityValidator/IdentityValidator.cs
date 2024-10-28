using IdentityValidator.Models;
using IdentityValidator.Models.Swedish;
using IdentityValidator.Validators;

namespace IdentityValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryAgain = true;

            while (tryAgain)
            {
                Console.WriteLine("Write your Swedish Personal Identity Number (for example 810724-9289): ");
                var inputPersonalIdentityNumber = Console.ReadLine();
                if (TryValidateNumber(() => new SwedishPersonalIdentityNumber(inputPersonalIdentityNumber!), out var personalIdentityNumber))
                {
                    NumberValidator.Validate(personalIdentityNumber);
                }

                Console.WriteLine("Write your Swedish Co-ordination Number (for example 19091079-9824): ");
                var inputCoordinationNumber = Console.ReadLine();
                if (TryValidateNumber(() => new SwedishCoordinatonNumber(inputCoordinationNumber!), out var coordinationNumber))
                {
                    NumberValidator.Validate(coordinationNumber);
                }

                Console.WriteLine("Write your Swedish Company Registration Number (for example 556601-6399): ");
                var inputCompanyRegistrationNumber = Console.ReadLine();
                if (TryValidateNumber(() => new SwedishCompanyRegistrationNumber(inputCompanyRegistrationNumber!), out var companyRegistrationNumber))
                {
                    NumberValidator.Validate(companyRegistrationNumber);
                }

                Console.WriteLine("Try Again? (y/n): ");
                var response = Console.ReadLine()?.ToLower();
                if (response != "y")
                {
                    tryAgain = false;
                    Console.WriteLine("See you again!");
                }
            }
        }
        static bool TryValidateNumber<T>(Func<T> createNumber, out T number) where T : IdentityNumber
        {
            try
            {
                number = createNumber();
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                number = null!;
                return false;
            }
        }
    }
}