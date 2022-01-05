using System.Collections.Generic;
using FluentAssertions;
using GSalvi.Utility.Validations;
using Xunit;

namespace GSalvi.Utility.UnitTests.Validations;

public class EmailAddressTests
{
    [Fact]
    public void IsEmailAddress_ShouldValidateCorrectly()
    {
        var wrong = new List<string?>
        {
            null,
            "",
            " ",
            "abc",
            "abc@",
            "abc@abc",
            "@abc",
            "@abc.com",
            "@abc.",
            "@com"
        };

        wrong.ForEach(x =>
        {
            var result = CommonValidations.IsEmailAddress(x);
            result.Should().BeFalse();
        });

        var right = new List<string?>
        {
            "abc@abc.com",
            "abc123@abc.com",
            "abc_123@abc.com"
        };

        right.ForEach(x =>
        {
            var result = CommonValidations.IsEmailAddress(x);
            result.Should().BeTrue();
        });
    }
}