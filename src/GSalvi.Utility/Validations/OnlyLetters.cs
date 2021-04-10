using System.Linq;

namespace GSalvi.Utility.Validations
{
    public partial class CommonValidations
    {
        public static bool IsOnlyLetters(string value)
        {
            return !string.IsNullOrWhiteSpace(value) && value.All(char.IsLetter);
        }
    }
}
