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
        [InlineData("0211000", "211", "000", "Düsseldorf")]
        [InlineData("021199999999", "211", "99999999", "Düsseldorf")]
        [InlineData("0212000", "212", "000", "Solingen")]
        [InlineData("021289999999", "212", "89999999", "Solingen")]
        [InlineData("0214000", "214", "000", "Leverkusen")]
        [InlineData("021499999999", "214", "99999999", "Leverkusen")]
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
        [InlineData("02102000", "2102", "000", "Ratingen")]
        [InlineData("0210299999999", "2102", "99999999", "Ratingen")]
        [InlineData("02103000", "2103", "000", "Hilden")]
        [InlineData("0210399999999", "2103", "99999999", "Hilden")]
        [InlineData("02104000", "2104", "000", "Mettmann")]
        [InlineData("0210499999999", "2104", "99999999", "Mettmann")]
        [InlineData("02129000", "2129", "000", "Haan Rheinland")]
        [InlineData("0212999999999", "2129", "99999999", "Haan Rheinland")]
        [InlineData("02131000", "2131", "000", "Neuss")]
        [InlineData("0213199999999", "2131", "99999999", "Neuss")]
        [InlineData("02132000", "2132", "000", "Meerbusch-Büderich")]
        [InlineData("0213299999999", "2132", "99999999", "Meerbusch-Büderich")]
        [InlineData("02133000", "2133", "000", "Dormagen")]
        [InlineData("0213399999999", "2133", "99999999", "Dormagen")]
        [InlineData("02137000", "2137", "000", "Neuss-Norf")]
        [InlineData("0213799999999", "2137", "99999999", "Neuss-Norf")]
        [InlineData("02150000", "2150", "000", "Meerbusch-Lank")]
        [InlineData("0215099999999", "2150", "99999999", "Meerbusch-Lank")]
        [InlineData("02151000", "2151", "000", "Krefeld")]
        [InlineData("0215199999999", "2151", "99999999", "Krefeld")]
        [InlineData("02152000", "2152", "000", "Kempen")]
        [InlineData("0215299999999", "2152", "99999999", "Kempen")]
        [InlineData("02153000", "2153", "000", "Nettetal-Lobberich")]
        [InlineData("0215399999999", "2153", "99999999", "Nettetal-Lobberich")]
        [InlineData("02154000", "2154", "000", "Willich")]
        [InlineData("0215499999999", "2154", "99999999", "Willich")]
        [InlineData("02156000", "2156", "000", "Willich-Anrath")]
        [InlineData("0215699999999", "2156", "99999999", "Willich-Anrath")]
        [InlineData("02157000", "2157", "000", "Nettetal-Kaldenkirchen")]
        [InlineData("0215799999999", "2157", "99999999", "Nettetal-Kaldenkirchen")]
        [InlineData("02158000", "2158", "000", "Grefrath bei Krefeld")]
        [InlineData("0215899999999", "2158", "99999999", "Grefrath bei Krefeld")]
        [InlineData("02159000", "2159", "000", "Meerbusch-Osterath")]
        [InlineData("0215999999999", "2159", "99999999", "Meerbusch-Osterath")]
        [InlineData("02161000", "2161", "000", "Mönchengladbach")]
        [InlineData("0216199999999", "2161", "99999999", "Mönchengladbach")]
        [InlineData("02162000", "2162", "000", "Viersen")]
        [InlineData("0216299999999", "2162", "99999999", "Viersen")]
        [InlineData("02163000", "2163", "000", "Schwalmtal Niederrhein")]
        [InlineData("0216399999999", "2163", "99999999", "Schwalmtal Niederrhein")]
        [InlineData("02164000", "2164", "000", "Jüchen-Otzenrath")]
        [InlineData("0216499999999", "2164", "99999999", "Jüchen-Otzenrath")]
        [InlineData("02165000", "2165", "000", "Jüchen")]
        [InlineData("0216599999999", "2165", "99999999", "Jüchen")]
        [InlineData("02166000", "2166", "000", "Mönchengladbach-Rheydt")]
        [InlineData("0216699999999", "2166", "99999999", "Mönchengladbach-Rheydt")]
        [InlineData("02171000", "2171", "000", "Leverkusen-Opladen")]
        [InlineData("0217199999999", "2171", "99999999", "Leverkusen-Opladen")]
        [InlineData("02173000", "2173", "000", "Langenfeld Rheinland")]
        [InlineData("0217399999999", "2173", "99999999", "Langenfeld Rheinland")]
        [InlineData("02174000", "2174", "000", "Langenfeld Rheinland")]
        [InlineData("0217499999999", "2174", "99999999", "Langenfeld Rheinland")]
        [InlineData("02175000", "2175", "000", "Leichlingen Rheinland")]
        [InlineData("0217599999999", "2175", "99999999", "Leichlingen Rheinland")]
        [InlineData("02181000", "2181", "000", "Grevenbroich")]
        [InlineData("0218199999999", "2181", "99999999", "Grevenbroich")]
        [InlineData("02182000", "2182", "000", "Grevenbroich-Kapellen")]
        [InlineData("0218299999999", "2182", "99999999", "Grevenbroich-Kapellen")]
        [InlineData("02183000", "2183", "000", "Rommerskirchen")]
        [InlineData("0218399999999", "2183", "99999999", "Rommerskirchen")]
        [InlineData("02191000", "2191", "000", "Remscheid")]
        [InlineData("0219199999999", "2191", "99999999", "Remscheid")]
        [InlineData("02192000", "2192", "000", "Hückeswagen")]
        [InlineData("0219299999999", "2192", "99999999", "Hückeswagen")]
        [InlineData("02193000", "2193", "000", "Dabringhausen")]
        [InlineData("0219399999999", "2193", "99999999", "Dabringhausen")]
        [InlineData("02195000", "2195", "000", "Radevormwald")]
        [InlineData("0219599999999", "2195", "99999999", "Radevormwald")]
        [InlineData("02196000", "2196", "000", "Wermelskirchen")]
        [InlineData("0219699999999", "2196", "99999999", "Wermelskirchen")]
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
