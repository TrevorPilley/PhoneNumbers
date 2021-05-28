using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Germany <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_DE_MobilePhoneNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Germany);

        [Theory]
        [InlineData("015020000000", "15020", "000000")]
        [InlineData("015020999999", "15020", "999999")]
        [InlineData("015050000000", "15050", "000000")]
        [InlineData("015050999999", "15050", "999999")]
        [InlineData("015080000000", "15080", "000000")]
        [InlineData("015080999999", "15080", "999999")]
        [InlineData("015110000000", "1511", "0000000")]
        [InlineData("015119999999", "1511", "9999999")]
        [InlineData("015120000000", "1512", "0000000")]
        [InlineData("015129999999", "1512", "9999999")]
        [InlineData("015140000000", "1514", "0000000")]
        [InlineData("015149999999", "1514", "9999999")]
        [InlineData("015170000000", "1517", "0000000")]
        [InlineData("015179999999", "1517", "9999999")]
        [InlineData("015200000000", "1520", "0000000")]
        [InlineData("015209999999", "1520", "9999999")]
        [InlineData("015230000000", "1523", "0000000")]
        [InlineData("015239999999", "1523", "9999999")]
        [InlineData("015250000000", "1525", "0000000")]
        [InlineData("015259999999", "1525", "9999999")]
        [InlineData("015260000000", "1526", "0000000")]
        [InlineData("015269999999", "1526", "9999999")]
        [InlineData("015290000000", "1529", "0000000")]
        [InlineData("015299999999", "1529", "9999999")]
        [InlineData("015555000000", "15555", "000000")]
        [InlineData("015555999999", "15555", "999999")]
        [InlineData("015630000000", "15630", "000000")]
        [InlineData("015630999999", "15630", "999999")]
        [InlineData("015678000000", "15678", "000000")]
        [InlineData("015678999999", "15678", "999999")]
        [InlineData("015700000000", "1570", "0000000")]
        [InlineData("015709999999", "1570", "9999999")]
        [InlineData("015730000000", "1573", "0000000")]
        [InlineData("015739999999", "1573", "9999999")]
        [InlineData("015750000000", "1575", "0000000")]
        [InlineData("015759999999", "1575", "9999999")]
        [InlineData("015770000000", "1577", "0000000")]
        [InlineData("015779999999", "1577", "9999999")]
        [InlineData("015790000000", "1579", "0000000")]
        [InlineData("015799999999", "1579", "9999999")]
        [InlineData("015888000000", "15888", "000000")]
        [InlineData("015888999999", "15888", "999999")]
        [InlineData("015900000000", "1590", "0000000")]
        [InlineData("015909999999", "1590", "9999999")]
        public void Parse_Known_MobilePhoneNumber_15XXX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Germany, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("01600000000", "160", "0000000")]
        [InlineData("016099999999", "160", "99999999")]
        [InlineData("01620000000", "162", "0000000")]
        [InlineData("01629999999", "162", "9999999")]
        [InlineData("01630000000", "163", "0000000")]
        [InlineData("01639999999", "163", "9999999")]
        public void Parse_Known_MobilePhoneNumber_16X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Germany, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("01700000000", "170", "0000000")]
        [InlineData("01709999999", "170", "9999999")]
        [InlineData("01750000000", "175", "0000000")]
        [InlineData("01759999999", "175", "9999999")]
        [InlineData("017600000000", "176", "00000000")]
        [InlineData("017699999999", "176", "99999999")]
        [InlineData("01770000000", "177", "0000000")]
        [InlineData("01779999999", "177", "9999999")]
        [InlineData("01790000000", "179", "0000000")]
        [InlineData("01799999999", "179", "9999999")]
        public void Parse_Known_MobilePhoneNumber_17X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Germany, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("018000000", "180", "00000")]
        [InlineData("01809999999", "180", "9999999")]
        [InlineData("018100000", "181", "00000")]
        [InlineData("018199999999999", "181", "99999999999")]
        [InlineData("018200000000", "182", "00000000")]
        [InlineData("018299999999", "182", "99999999")]
        [InlineData("018900000000", "189", "00000000")]
        [InlineData("018999999999", "189", "99999999")]
        public void Parse_Known_MobilePhoneNumber_18X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Germany, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("01640", "164", "0")]
        [InlineData("01649999999999", "164", "9999999999")]
        [InlineData("01680", "168", "0")]
        [InlineData("016899999999999", "168", "99999999999")]
        [InlineData("01690", "169", "0")]
        [InlineData("016999999999999", "169", "99999999999")]
        public void Parse_Known_MobilePhoneNumber_Pager(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Germany, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.True(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }
    }
}
