using System.Text;

namespace GSalvi.Utility.StringExtensions;

public static partial class StringExtension
{
    public static string NormalizeAccentedChars(this string? value)
    {
        if (value is null) return string.Empty;

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var bytes = Encoding.GetEncoding("iso-8859-8").GetBytes(value);
        return Encoding.UTF8.GetString(bytes);
    }
}