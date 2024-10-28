using IdentityValidator.Extensions;

namespace IdentityValidator.Models
{
    public abstract class IdentityNumber
    {
        protected readonly string originalNumber;
        public string Number { get; protected set; }

        protected IdentityNumber(string number, int[] validLengths)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Field can't be empty.");

            originalNumber = number;
            Number = number.CleanNumber();

            ValidateLength(validLengths);
        }

        private void ValidateLength(int[] validLengths)
        {
            if (!validLengths.Contains(Number.Length))
            {
                throw new ArgumentException("Invalid format");
            }
        }

        public abstract bool IsValid();

        public override string ToString()
        {
            return originalNumber;
        }
    }
}