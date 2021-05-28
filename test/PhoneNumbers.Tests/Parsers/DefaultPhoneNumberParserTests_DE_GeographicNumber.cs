using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Germany <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_DE_GeographicNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Germany);

        [Theory]
        [InlineData("0201000", "201", "000", "Essen")]
        [InlineData("020199999999", "201", "99999999", "Essen")]
        [InlineData("0202000", "202", "000", "Wuppertal")]
        [InlineData("020299999999", "202", "99999999", "Wuppertal")]
        [InlineData("0203000", "203", "000", "Duisburg")]
        [InlineData("020399999999", "203", "99999999", "Duisburg")]
        [InlineData("0208000", "208", "000", "Oberhausen")]
        [InlineData("020899999999", "208", "99999999", "Oberhausen")]
        [InlineData("0209000", "209", "000", "Gelsenkirchen")]
        [InlineData("020999999999", "209", "99999999", "Gelsenkirchen")]
        public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Germany, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0204100", "2041", "00", "Bottrop")]
        [InlineData("020419999999", "2041", "9999999", "Bottrop")]
        [InlineData("0204300", "2043", "00", "Gladbeck")]
        [InlineData("020439999999", "2043", "9999999", "Gladbeck")]
        [InlineData("0204500", "2045", "00", "Bottrop-Kirchhellen")]
        [InlineData("020459999999", "2045", "9999999", "Bottrop-Kirchhellen")]
        [InlineData("0205100", "2051", "00", "Velbert")]
        [InlineData("020519999999", "2051", "9999999", "Velbert")]
        [InlineData("0205200", "2052", "00", "Velbert-Langenberg")]
        [InlineData("020529999999", "2052", "9999999", "Velbert-Langenberg")]
        [InlineData("0205300", "2053", "00", "Velbert-Neviges")]
        [InlineData("020539999999", "2053", "9999999", "Velbert-Neviges")]
        [InlineData("0205400", "2054", "00", "Essen-Kettwig")]
        [InlineData("020549999999", "2054", "9999999", "Essen-Kettwig")]
        [InlineData("0205600", "2056", "00", "Heiligenhaus")]
        [InlineData("020569999999", "2056", "9999999", "Heiligenhaus")]
        [InlineData("0205800", "2058", "00", "Wülfrath")]
        [InlineData("020589999999", "2058", "9999999", "Wülfrath")]
        [InlineData("0206400", "2064", "00", "Dinslaken")]
        [InlineData("020649999999", "2064", "9999999", "Dinslaken")]
        [InlineData("0206500", "2065", "00", "Duisburg-Rheinhausen")]
        [InlineData("020659999999", "2065", "9999999", "Duisburg-Rheinhausen")]
        [InlineData("0206600", "2066", "00", "Duisburg-Homberg")]
        [InlineData("020669999999", "2066", "9999999", "Duisburg-Homberg")]
        public void Parse_Known_GeographicPhoneNumber_2XXX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Germany, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("030000000000", "30", "000000000", "Berlin")]
        [InlineData("030999999999", "30", "999999999", "Berlin")]
        public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Germany, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }
    }
}
