using System.Collections.Generic;
using FluentAssertions;
using GSalvi.Utility.Validations;
using Xunit;

namespace GSalvi.Utility.UnitTests.Validations
{
    public class OnlyDigitsTests
    {
        [Fact]
        public void IsOnlyDigits()
        {
            var wrong = new List<string>
            {
                null,
                "",
                " ",
                "123Abc",
                "123!@",
                "123 456"
            };

            wrong.ForEach(x =>
            {
                var result = CommonValidations.IsOnlyDigits(x);
                result.Should().BeFalse();
            });

            var right = new List<string>
            {
                "123"
            };

            right.ForEach(x =>
            {
                var result = CommonValidations.IsOnlyDigits(x);
                result.Should().BeTrue();
            });
        }
    }
}