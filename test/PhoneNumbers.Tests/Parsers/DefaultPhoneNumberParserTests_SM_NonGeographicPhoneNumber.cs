using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for SM <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_SM_NonGeographicPhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.SanMarino);

        [Theory]
        [InlineData("000000", "000000")]
        [InlineData("099999", "099999")]
        [InlineData("500000", "500000")]
        [InlineData("599999", "599999")]
        [InlineData("700000", "700000")]
        [InlineData("999999", "999999")]
        [InlineData("0000000", "0000000")]
        [InlineData("0999999", "0999999")]
        [InlineData("5000000", "5000000")]
        [InlineData("5999999", "5999999")]
        [InlineData("7000000", "7000000")]
        [InlineData("9999999", "9999999")]
        [InlineData("00000000", "00000000")]
        [InlineData("09999999", "09999999")]
        [InlineData("50000000", "50000000")]
        [InlineData("59999999", "59999999")]
        [InlineData("70000000", "70000000")]
        [InlineData("99999999", "99999999")]
        [InlineData("000000000", "000000000")]
        [InlineData("099999999", "099999999")]
        [InlineData("500000000", "500000000")]
        [InlineData("599999999", "599999999")]
        [InlineData("700000000", "700000000")]
        [InlineData("999999999", "999999999")]
        [InlineData("0000000000", "0000000000")]
        [InlineData("0999999999", "0999999999")]
        [InlineData("5000000000", "5000000000")]
        [InlineData("5999999999", "5999999999")]
        [InlineData("7000000000", "7000000000")]
        [InlineData("9999999999", "9999999999")]
        public void Parse_Known_NonGeographicPhoneNumber(string value, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Null(nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.SanMarino, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(localNumber, nonGeographicPhoneNumber.LocalNumber);
        }
    }
}