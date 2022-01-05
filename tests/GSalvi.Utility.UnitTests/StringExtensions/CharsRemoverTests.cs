using FluentAssertions;
using GSalvi.Utility.StringExtensions;
using Xunit;

namespace GSalvi.Utility.UnitTests.StringExtensions;

public class CharsRemoverTests
{
    [Fact]
    public void RemoveChars_ShouldRemoveCharsCorrectly()
    {
        const string value = "abc@$#def!&* ghi";
        const string expected = "abcdef ghi";

        var result = value.RemoveChars('@', '$', '#', '!', '&', '*');

        result.Should().Be(expected);
    }

    [Fact]
    public void RemoveChars_ShouldReturnEmptyString_WhenValueIsNull()
    {
        const string? value = null;
        var expected = string.Empty;

        var result = value.RemoveChars();

        result.Should().Be(expected);
    }

    [Fact]
    public void RemoveCharsNotIn_ShouldRemoveCharsCorrectly()
    {
        const string value = "abcd!@#$efgh1234ijkl";
        const string expected = "abcdefghijkl";

        var result = value.RemoveCharsNotIn("abcdefghijkl".ToCharArray());

        result.Should().Be(expected);
    }


    [Fact]
    public void RemoveCharsNotIn_ShouldReturnEmptyString_WhenValueIsNull()
    {
        const string? value = null;
        var expected = string.Empty;

        var result = value.RemoveCharsNotIn();

        result.Should().Be(expected);
    }
}