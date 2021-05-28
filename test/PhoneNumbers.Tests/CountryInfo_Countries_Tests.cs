using Xunit;

namespace PhoneNumbers.Tests
{
    public class CountryInfo_Countries_Tests
    {
        [Fact]
        public void CountryInfo_Belgium()
        {
            Assert.Same(CountryInfo.Belgium, CountryInfo.Belgium);

            var countryInfo = CountryInfo.Belgium;

            Assert.Equal("+32", countryInfo.CallingCode);
            Assert.True(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("BE", countryInfo.Iso3166Code);
            Assert.Equal("Belgium", countryInfo.Name);
            Assert.Equal(new[] { 3, 2, 1 }, countryInfo.NdcLengths);
            Assert.Equal(new[] { 8, 9 }, countryInfo.NsnLengths);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_France()
        {
            Assert.Same(CountryInfo.France, CountryInfo.France);

            var countryInfo = CountryInfo.France;

            Assert.Equal("+33", countryInfo.CallingCode);
            Assert.False(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("FR", countryInfo.Iso3166Code);
            Assert.Equal("France", countryInfo.Name);
            Assert.Empty(countryInfo.NdcLengths);
            Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_Germany()
        {
            Assert.Same(CountryInfo.Germany, CountryInfo.Germany);

            var countryInfo = CountryInfo.Germany;

            Assert.Equal("+49", countryInfo.CallingCode);
            Assert.True(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("DE", countryInfo.Iso3166Code);
            Assert.Equal("Germany", countryInfo.Name);
            Assert.Equal(new[] { 5, 4, 3, 2 }, countryInfo.NdcLengths);
            Assert.Equal(new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, countryInfo.NsnLengths);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_Guernsey()
        {
            Assert.Same(CountryInfo.Guernsey, CountryInfo.Guernsey);

            var countryInfo = CountryInfo.Guernsey;

            Assert.Equal("+44", countryInfo.CallingCode);
            Assert.True(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("GG", countryInfo.Iso3166Code);
            Assert.Equal("Guernsey", countryInfo.Name);
            Assert.Equal(new[] { 4 }, countryInfo.NdcLengths);
            Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
            Assert.True(countryInfo.SharesCallingCode);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_HongKong()
        {
            Assert.Same(CountryInfo.HongKong, CountryInfo.HongKong);

            var countryInfo = CountryInfo.HongKong;

            Assert.Equal("+852", countryInfo.CallingCode);
            Assert.False(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("001", countryInfo.InternationalCallPrefix);
            Assert.Equal("HK", countryInfo.Iso3166Code);
            Assert.Equal("Hong Kong", countryInfo.Name);
            Assert.Empty(countryInfo.NdcLengths);
            Assert.Equal(new[] { 8, 9 }, countryInfo.NsnLengths);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_Ireland()
        {
            Assert.Same(CountryInfo.Ireland, CountryInfo.Ireland);

            var countryInfo = CountryInfo.Ireland;

            Assert.Equal("+353", countryInfo.CallingCode);
            Assert.True(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("IE", countryInfo.Iso3166Code);
            Assert.Equal("Ireland", countryInfo.Name);
            Assert.Equal(new[] { 3, 2, 1 }, countryInfo.NdcLengths);
            Assert.Equal(new[] { 7, 8, 9 }, countryInfo.NsnLengths);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_IsleOfMan()
        {
            Assert.Same(CountryInfo.IsleOfMan, CountryInfo.IsleOfMan);

            var countryInfo = CountryInfo.IsleOfMan;

            Assert.Equal("+44", countryInfo.CallingCode);
            Assert.True(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("IM", countryInfo.Iso3166Code);
            Assert.Equal("Isle of Man", countryInfo.Name);
            Assert.Equal(new[] { 4 }, countryInfo.NdcLengths);
            Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
            Assert.True(countryInfo.SharesCallingCode);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_Italy()
        {
            Assert.Same(CountryInfo.Italy, CountryInfo.Italy);

            var countryInfo = CountryInfo.Italy;

            Assert.Equal("+39", countryInfo.CallingCode);
            Assert.True(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("IT", countryInfo.Iso3166Code);
            Assert.Equal("Italy", countryInfo.Name);
            Assert.Equal(new[] { 5, 4, 3, 2 }, countryInfo.NdcLengths);
            Assert.Equal(new[] { 5, 6, 7, 8, 9, 10, 11 }, countryInfo.NsnLengths);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_Jersey()
        {
            Assert.Same(CountryInfo.Jersey, CountryInfo.Jersey);

            var countryInfo = CountryInfo.Jersey;

            Assert.Equal("+44", countryInfo.CallingCode);
            Assert.True(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("JE", countryInfo.Iso3166Code);
            Assert.Equal("Jersey", countryInfo.Name);
            Assert.Equal(new[] { 4 }, countryInfo.NdcLengths);
            Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
            Assert.True(countryInfo.SharesCallingCode);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_Macau()
        {
            Assert.Same(CountryInfo.Macau, CountryInfo.Macau);

            var countryInfo = CountryInfo.Macau;

            Assert.Equal("+853", countryInfo.CallingCode);
            Assert.False(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("MO", countryInfo.Iso3166Code);
            Assert.Equal("Macau", countryInfo.Name);
            Assert.Empty(countryInfo.NdcLengths);
            Assert.Equal(new[] { 8 }, countryInfo.NsnLengths);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_Monaco()
        {
            Assert.Same(CountryInfo.Monaco, CountryInfo.Monaco);

            var countryInfo = CountryInfo.Monaco;

            Assert.Equal("+377", countryInfo.CallingCode);
            Assert.False(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("MC", countryInfo.Iso3166Code);
            Assert.Equal("Monaco", countryInfo.Name);
            Assert.Empty(countryInfo.NdcLengths);
            Assert.Equal(new[] { 8, 9 }, countryInfo.NsnLengths);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_Netherlands()
        {
            Assert.Same(CountryInfo.Netherlands, CountryInfo.Netherlands);

            var countryInfo = CountryInfo.Netherlands;

            Assert.Equal("+31", countryInfo.CallingCode);
            Assert.True(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("NL", countryInfo.Iso3166Code);
            Assert.Equal("Netherlands", countryInfo.Name);
            Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
            Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_Portugal()
        {
            Assert.Same(CountryInfo.Portugal, CountryInfo.Portugal);

            var countryInfo = CountryInfo.Portugal;

            Assert.Equal("+351", countryInfo.CallingCode);
            Assert.True(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("PT", countryInfo.Iso3166Code);
            Assert.Equal("Portugal", countryInfo.Name);
            Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
            Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_SanMarino()
        {
            Assert.Same(CountryInfo.SanMarino, CountryInfo.SanMarino);

            var countryInfo = CountryInfo.SanMarino;

            Assert.Equal("+378", countryInfo.CallingCode);
            Assert.False(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("SM", countryInfo.Iso3166Code);
            Assert.Equal("San Marino", countryInfo.Name);
            Assert.Empty(countryInfo.NdcLengths);
            Assert.Equal(new[] { 6, 7, 8, 9, 10 }, countryInfo.NsnLengths);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_Singapore()
        {
            Assert.Same(CountryInfo.Singapore, CountryInfo.Singapore);

            var countryInfo = CountryInfo.Singapore;

            Assert.Equal("+65", countryInfo.CallingCode);
            Assert.False(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("001", countryInfo.InternationalCallPrefix);
            Assert.Equal("SG", countryInfo.Iso3166Code);
            Assert.Equal("Singapore", countryInfo.Name);
            Assert.Empty(countryInfo.NdcLengths);
            Assert.Equal(new[] { 8, 10, 11 }, countryInfo.NsnLengths);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_Spain()
        {
            Assert.Same(CountryInfo.Spain, CountryInfo.Spain);

            var countryInfo = CountryInfo.Spain;

            Assert.Equal("+34", countryInfo.CallingCode);
            Assert.True(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("ES", countryInfo.Iso3166Code);
            Assert.Equal("Spain", countryInfo.Name);
            Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
            Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_Switzerland()
        {
            Assert.Same(CountryInfo.Switzerland, CountryInfo.Switzerland);

            var countryInfo = CountryInfo.Switzerland;

            Assert.Equal("+41", countryInfo.CallingCode);
            Assert.True(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("CH", countryInfo.Iso3166Code);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Equal("Switzerland", countryInfo.Name);
            Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
            Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_UnitedKingdom()
        {
            Assert.Same(CountryInfo.UnitedKingdom, CountryInfo.UnitedKingdom);

            var countryInfo = CountryInfo.UnitedKingdom;

            Assert.Equal("+44", countryInfo.CallingCode);
            Assert.True(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("GB", countryInfo.Iso3166Code);
            Assert.Equal("United Kingdom", countryInfo.Name);
            Assert.Equal(new[] { 5, 4, 3, 2 }, countryInfo.NdcLengths);
            Assert.Equal(new[] { 7, 9, 10 }, countryInfo.NsnLengths);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }
    }
}
