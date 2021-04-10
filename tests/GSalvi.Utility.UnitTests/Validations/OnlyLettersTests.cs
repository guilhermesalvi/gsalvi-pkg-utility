using GSalvi.Utility.Validations;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace GSalvi.Utility.UnitTests.Validations
{
    public class OnlyLettersTests
    {
        [Fact]
        public void IsOnlyDigits()
        {
            var wrong = new List<string>
            {
                null,
                "",
                " ",
                "Abc123",
                "Abc!@def",
                "Abc def"
            };

            wrong.ForEach(x =>
            {
                var result = CommonValidations.IsOnlyLetters(x);
                result.Should().BeFalse();
            });

            var right = new List<string>
            {
                "Abc",
                "ABC",
                "abc"
            };

            right.ForEach(x =>
            {
                var result = CommonValidations.IsOnlyLetters(x);
                result.Should().BeTrue();
            });
        }
    }
}
