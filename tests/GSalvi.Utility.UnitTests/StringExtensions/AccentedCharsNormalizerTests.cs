using FluentAssertions;
using GSalvi.Utility.StringExtensions;
using Xunit;

namespace GSalvi.Utility.UnitTests.StringExtensions
{
    public class AccentedCharsNormalizerTests
    {
        [Fact]
        public void NormalizeAccentedChars()
        {
            const string value = "ÁÉÍÓÚ áéíóú ÂÊÔ âêô Àà Üü Çç Ññ ÃÕ ãõ";
            const string expected = "AEIOU aeiou AEO aeo Aa Uu Cc Nn AO ao";

            var result = value.NormalizeAccentedChars();

            result.Should().Be(expected);
        }

        [Fact]
        public void ReturnEmptyStringWhenValueIsNull()
        {
            const string value = null;
            var expected = string.Empty;

            var result = value.NormalizeAccentedChars();

            result.Should().Be(expected);
        }
    }
}
