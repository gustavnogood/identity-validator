namespace IdentityValidator.Validators.ValidityLogic
{
    public static class LuhnValidator
    {
        public static bool IsValid(string number)
        {
            try
            {
                int sum = 0;
                bool alternate = false;
                
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    int n = int.Parse(number[i].ToString());
                    if (alternate)
                    {
                        n *= 2;
                        if (n > 9)
                        {
                            n -= 9;
                        }
                    }
                    sum += n;
                    alternate = !alternate;
                }
                return sum % 10 == 0;
            }
            catch (FormatException ex)
                {
                    Console.WriteLine($"Wrong format in Luhn: {ex.Message}");
                    return false;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Wrong value in Luhn: {ex.Message}");
                    return false;
                }
        }
    }
}