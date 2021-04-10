using FluentAssertions;
using GSalvi.Utility.StringExtensions;
using Xunit;

namespace GSalvi.Utility.UnitTests.StringExtensions
{
    public class DuplicatedSpacesRemoverTests
    {
        [Fact]
        public void RemoveDuplicateSpaces()
        {
            const string value = "Lorem ipsum  quam suspendisse      curabitur  platea, fusce cubilia  dapibus   fusce.";
            const string expected = "Lorem ipsum quam suspendisse curabitur platea, fusce cubilia dapibus fusce.";

            var result = value.RemoveDuplicateSpaces();

            result.Should().Be(expected);
        }

        [Fact]
        public void ReturnEmptyStringWhenValueIsNull()
        {
            const string value = null;
            var expected = string.Empty;

            var result = value.RemoveDuplicateSpaces();

            result.Should().Be(expected);
        }
    }
}
