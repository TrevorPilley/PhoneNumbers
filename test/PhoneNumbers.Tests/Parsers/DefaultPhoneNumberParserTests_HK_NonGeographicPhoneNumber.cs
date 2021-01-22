using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for HK <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_HK_NonGeographicPhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.HongKong);

        [Theory]
        [InlineData("20100000", "20100000")]
        [InlineData("20199999", "20199999")]
        [InlineData("20200000", "20200000")]
        [InlineData("20209999", "20209999")]
        [InlineData("20210000", "20210000")]
        [InlineData("20699999", "20699999")]
        [InlineData("21000000", "21000000")]
        [InlineData("29999999", "29999999")]
        [InlineData("31000000", "31000000")]
        [InlineData("31999999", "31999999")]
        [InlineData("34000000", "34000000")]
        [InlineData("39999999", "39999999")]
        [InlineData("58000000", "58000000")]
        [InlineData("58999999", "58999999")]
        public void Parse_Known_NonGeographicPhoneNumber(string value, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Null(nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.HongKong, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(localNumber, nonGeographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("800000000", "800000000")]
        [InlineData("809999999", "809999999")]
        public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Null(nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.HongKong, nonGeographicPhoneNumber.Country);
            Assert.True(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(localNumber, nonGeographicPhoneNumber.LocalNumber);
        }
    }
}