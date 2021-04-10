using System.Collections.Generic;
using FluentAssertions;
using GSalvi.Utility.Validations;
using Xunit;

namespace GSalvi.Utility.UnitTests.Validations
{
    public class OnlyCharsTests
    {
        [Fact]
        public void HasOnlyChars()
        {
            var wrong = new List<(string Actual, char[] Expected)>
            {
                ("abc 123", "321cba".ToCharArray())
            };

            wrong.ForEach(x =>
            {
                var (actual, expected) = x;
                var result = CommonValidations.HasOnlyChars(actual, expected);
                result.Should().BeFalse();
            });

            var right = new List<(string Actual, char[] Expected)>
            {
                ("abc 123", " 321cba".ToCharArray())
            };

            right.ForEach(x =>
            {
                var (actual, expected) = x;
                var result = CommonValidations.HasOnlyChars(actual, expected);
                result.Should().BeTrue();
            });
        }
    }
}
