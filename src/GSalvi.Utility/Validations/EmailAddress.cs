using System.Text.RegularExpressions;

namespace GSalvi.Utility.Validations;

public static partial class CommonValidations
{
    public static bool IsEmailAddress(string? value)
    {
        const string pattern =
            @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        return Regex.IsMatch(value ?? string.Empty, pattern, RegexOptions.IgnoreCase);
    }
}