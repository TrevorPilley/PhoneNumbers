using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="MCPhoneNumberFormatter"/> class.
    /// </summary>
    public class MCPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = new MCPhoneNumberFormatter();

        [Theory]
        [InlineData("98988800", "98 98 88 00")]
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "MC"), "D"));
    }
}
