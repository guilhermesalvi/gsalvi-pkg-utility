using System.Text;

namespace GSalvi.Utility.StringExtensions
{
    public static partial class StringExtension
    {
        public static string RemoveDuplicateSpaces(this string value)
        {
            if (value is null) return string.Empty;

            var sb = new StringBuilder();

            for (var i = 0; i < value.Length; i++)
            {
                var add = !(i != 0 && 
                            char.IsWhiteSpace(value[i]) &&
                            char.IsWhiteSpace(value[i - 1]));

                if (add)
                {
                    sb.Append(value[i]);
                }
            }

            return sb.ToString();
        }
    }
}
