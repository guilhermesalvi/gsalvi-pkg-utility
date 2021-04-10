using FluentAssertions;
using GSalvi.Utility.StringExtensions;
using Xunit;

namespace GSalvi.Utility.UnitTests.StringExtensions
{
    public class CharsRemoverTests
    {
        [Fact]
        public void RemoveChars()
        {
            const string value = @"abc@$#def!&* ghi";
            const string expected = "abcdef ghi";

            var result = value.RemoveChars('@', '$', '#', '!', '&', '*');

            result.Should().Be(expected);
        }

        [Fact]
        public void ReturnEmptyStringWhenValueIsNull()
        {
            const string value = null;
            var expected = string.Empty;

            var result = value.RemoveChars();

            result.Should().Be(expected);
        }
    }
}
