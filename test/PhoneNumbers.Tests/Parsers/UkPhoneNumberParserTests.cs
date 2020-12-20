using System;
using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="UkPhoneNumberParser"/> class.
    /// </summary>
    /// <remarks>
    /// All valid number tests use the local council number for the area code.
    /// </remarks>
    public class UkPhoneNumberParserTests
    {
        [Theory]
        [InlineData("01132224444", "113", "2224444", "Leeds")]
        [InlineData("01142734567", "114", "2734567", "Sheffield")]
        [InlineData("01159155555", "115", "9155555", "Nottingham")]
        [InlineData("01164541002", "116", "4541002", "Leicester")]
        [InlineData("01179222000", "117", "9222000", "Bristol")]
        [InlineData("01189373787", "118", "9373787", "Reading")]
        public void Parse_1XX_Known_PhoneNumbers(string value, string areaCode, string localNumber, string geographicArea)
        {
            var parser = new UkPhoneNumberParser();
            var phoneNumber = parser.Parse(value);

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal("+44", geographicPhoneNumber.CallingCode);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
            Assert.Equal("0", geographicPhoneNumber.TrunkPrefix);
        }

        [Theory]
        [InlineData("01100000000")]
        [InlineData("01110000000")]
        [InlineData("01120000000")]
        [InlineData("01190000000")]
        public void Parse_1XX_Unknown_Number_Throws_Exception(string value)
        {
            var parser = new UkPhoneNumberParser();
            var exception = Assert.Throws<NotSupportedException>(() => parser.Parse(value));
        }

        [Fact]
        public void Parse_Throws_Exception_If_ServiceType_Invalid()
        {
            var parser = new UkPhoneNumberParser();
            var exception = Assert.Throws<NotSupportedException>(() => parser.Parse("0411111111"));
        }

        [Fact]
        public void Parse_Throws_Exception_If_TrunkPrefix_Invalid()
        {
            var parser = new UkPhoneNumberParser();
            var exception = Assert.Throws<NotSupportedException>(() => parser.Parse("1111111111"));
        }
    }
}
