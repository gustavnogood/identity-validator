namespace IdentityValidator.Extensions
{
    public static class StringExtensions
    {
        public static string CleanNumber(this string number)
        {
            return string.Join("", number.Where(char.IsDigit));
        }
    }
}