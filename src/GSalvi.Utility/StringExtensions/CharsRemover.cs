using System.Linq;
using System.Text;

namespace GSalvi.Utility.StringExtensions
{
    public static partial class StringExtension
    {
        public static string RemoveChars(this string value, params char[] chars)
        {
            if (value is null) return string.Empty;

            var sb = new StringBuilder();

            foreach (var c in from c in value let add = chars.All(t => t != c) where add select c)
            {
                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
