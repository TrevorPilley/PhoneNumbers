using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Israel <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_IL_MobilePhoneNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Israel);

        [Theory]
        [InlineData("0500000000", "50", "0000000")]
        [InlineData("0509999999", "50", "9999999")]
        public void Parse_Known_MobilePhoneNumber_50_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Israel, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0540000000", "54", "0000000")]
        [InlineData("0549999999", "54", "9999999")]
        public void Parse_Known_MobilePhoneNumber_54_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Israel, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0552200000", "55", "2200000")]
        [InlineData("0552999999", "55", "2999999")]
        [InlineData("0553200000", "55", "3200000")]
        [InlineData("0553399999", "55", "3399999")]
        [InlineData("0554300000", "55", "4300000")]
        [InlineData("0554399999", "55", "4399999")]
        [InlineData("0555000000", "55", "5000000")]
        [InlineData("0555199999", "55", "5199999")]
        [InlineData("0555500000", "55", "5500000")]
        [InlineData("0555699999", "55", "5699999")]
        [InlineData("0556600000", "55", "6600000")]
        [InlineData("0556899999", "55", "6899999")]
        [InlineData("0557000000", "55", "7000000")]
        [InlineData("0557299999", "55", "7299999")]
        [InlineData("0558700000", "55", "8700000")]
        [InlineData("0558999999", "55", "8999999")]
        [InlineData("0559100000", "55", "9100000")]
        [InlineData("0559999999", "55", "9999999")]
        public void Parse_Known_MobilePhoneNumber_55_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Israel, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0562000000", "56", "2000000")]
        [InlineData("0569999999", "56", "9999999")]
        public void Parse_Known_MobilePhoneNumber_56_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Israel, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0580000000", "58", "0000000")]
        [InlineData("0589999999", "58", "9999999")]
        public void Parse_Known_MobilePhoneNumber_58_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Israel, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0590000000", "59", "0000000")]
        [InlineData("0599999999", "59", "9999999")]
        public void Parse_Known_MobilePhoneNumber_59_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Israel, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }
    }
}
