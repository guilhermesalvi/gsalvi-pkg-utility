using System.Linq;

namespace GSalvi.Utility.Validations;

public static partial class CommonValidations
{
    public static bool HasOnlyChars(string? value, params char[] chars)
    {
        return value is not null && value.Select(c => chars.Any(t => t == c)).All(isIn => isIn);
    }
}