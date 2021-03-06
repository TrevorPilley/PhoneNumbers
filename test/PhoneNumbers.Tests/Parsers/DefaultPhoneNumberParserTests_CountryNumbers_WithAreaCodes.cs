using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class with <see cref="CountryNumber"/>s using area codes.
    /// </summary>
    public class DefaultPhoneNumberParserTests_CountryNumbers_WithNationalDiallingCodes
    {
        private readonly CountryInfo _countryInfo = TestHelper.CreateCountryInfo(
            areaCodeLengths: new[] { 3, 2 },
            nsnLengths: new[] { 7 });

        private readonly PhoneNumberParser _parser;

        public DefaultPhoneNumberParserTests_CountryNumbers_WithNationalDiallingCodes() =>
            _parser = new DefaultPhoneNumberParser(
                _countryInfo,
                new[]
                {
                    new CountryNumber
                    {
                        NationalDiallingCodeRanges = new[] { NumberRange.Create("40") },
                        GeographicArea = "Springfield",
                        SubscriberNumberRanges = new[] { NumberRange.Create("10000-20999"), NumberRange.Create("40000-90999") },
                        Kind = PhoneNumberKind.GeographicPhoneNumber,
                        Hint = PhoneNumberHint.None,
                    },
                    new CountryNumber
                    {
                        NationalDiallingCodeRanges = new[] { NumberRange.Create("403") },
                        GeographicArea = "Springfield B",
                        SubscriberNumberRanges = new[] { NumberRange.Create("1000-2099") },
                        Kind = PhoneNumberKind.GeographicPhoneNumber,
                        Hint = PhoneNumberHint.None,
                    },
                    new CountryNumber
                    {
                        NationalDiallingCodeRanges = new[] { NumberRange.Create("70") },
                        SubscriberNumberRanges = new[] { NumberRange.Create("10000-10999") },
                        Kind = PhoneNumberKind.MobilePhoneNumber,
                        Hint = PhoneNumberHint.None,
                    },
                    new CountryNumber
                    {
                        NationalDiallingCodeRanges = new[] { NumberRange.Create("70") },
                        SubscriberNumberRanges = new[] { NumberRange.Create("11000-11999") },
                        Kind = PhoneNumberKind.MobilePhoneNumber,
                        Hint = PhoneNumberHint.Data,
                    },
                    new CountryNumber
                    {
                        NationalDiallingCodeRanges = new[] { NumberRange.Create("71") },
                        SubscriberNumberRanges = new[] { NumberRange.Create("12000-12999") },
                        Kind = PhoneNumberKind.MobilePhoneNumber,
                        Hint = PhoneNumberHint.Pager,
                    },
                    new CountryNumber
                    {
                        NationalDiallingCodeRanges = new[] { NumberRange.Create("72") },
                        SubscriberNumberRanges = new[] { NumberRange.Create("13000-13999") },
                        Kind = PhoneNumberKind.MobilePhoneNumber,
                        Hint = PhoneNumberHint.Virtual,
                    },
                    new CountryNumber
                    {
                        NationalDiallingCodeRanges = new[] { NumberRange.Create("50") },
                        SubscriberNumberRanges = new[] { NumberRange.Create("20000-20999") },
                        Kind = PhoneNumberKind.NonGeographicPhoneNumber,
                        Hint = PhoneNumberHint.None,
                    },
                    new CountryNumber
                    {
                        NationalDiallingCodeRanges = new[] { NumberRange.Create("60") },
                        SubscriberNumberRanges = new[] { NumberRange.Create("28000-28999") },
                        Kind = PhoneNumberKind.NonGeographicPhoneNumber,
                        Hint = PhoneNumberHint.Freephone,
                    },
                    new CountryNumber
                    {
                        NationalDiallingCodeRanges = new[] { NumberRange.Create("70") },
                        SubscriberNumberRanges = new[] { NumberRange.Create("28000-28999") },
                        Kind = PhoneNumberKind.NonGeographicPhoneNumber,
                        Hint = PhoneNumberHint.PremiumRate,
                    },
                });

        [Fact]
        public void Parse_GeographicPhoneNumber()
        {
            var phoneNumber = _parser.Parse("4010000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal("40", geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(_countryInfo, geographicPhoneNumber.Country);
            Assert.Equal("Springfield", geographicPhoneNumber.GeographicArea);
            Assert.Equal("10000", geographicPhoneNumber.SubscriberNumber);
            Assert.Equal(PhoneNumberKind.GeographicPhoneNumber, geographicPhoneNumber.PhoneNumberKind);
        }

        [Fact]
        public void Parse_GeographicPhoneNumber_In_Sub_NationalDiallingCode()
        {
            var phoneNumber = _parser.Parse("4031000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal("403", geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(_countryInfo, geographicPhoneNumber.Country);
            Assert.Equal("Springfield B", geographicPhoneNumber.GeographicArea);
            Assert.Equal("1000", geographicPhoneNumber.SubscriberNumber);
            Assert.Equal(PhoneNumberKind.GeographicPhoneNumber, geographicPhoneNumber.PhoneNumberKind);
        }

        [Fact]
        public void Parse_Invalid_Number() =>
            Assert.Equal("The national significant number 9005500 is not valid for a Zulu phone number.", _parser.Parse("9005500").ParseError);

        [Fact]
        public void Parse_MobilePhoneNumber()
        {
            var phoneNumber = _parser.Parse("7010000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal("70", mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(_countryInfo, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal("10000", mobilePhoneNumber.SubscriberNumber);
            Assert.Equal(PhoneNumberKind.MobilePhoneNumber, mobilePhoneNumber.PhoneNumberKind);
        }

        [Fact]
        public void Parse_MobilePhoneNumber_Data()
        {
            var phoneNumber = _parser.Parse("7011000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal("70", mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(_countryInfo, mobilePhoneNumber.Country);
            Assert.True(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal("11000", mobilePhoneNumber.SubscriberNumber);
            Assert.Equal(PhoneNumberKind.MobilePhoneNumber, mobilePhoneNumber.PhoneNumberKind);
        }

        [Fact]
        public void Parse_MobilePhoneNumber_Pager()
        {
            var phoneNumber = _parser.Parse("7112000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal("71", mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(_countryInfo, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.True(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal("12000", mobilePhoneNumber.SubscriberNumber);
            Assert.Equal(PhoneNumberKind.MobilePhoneNumber, mobilePhoneNumber.PhoneNumberKind);
        }

        [Fact]
        public void Parse_MobilePhoneNumber_Virtual()
        {
            var phoneNumber = _parser.Parse("7213000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal("72", mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(_countryInfo, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.True(mobilePhoneNumber.IsVirtual);
            Assert.Equal("13000", mobilePhoneNumber.SubscriberNumber);
            Assert.Equal(PhoneNumberKind.MobilePhoneNumber, mobilePhoneNumber.PhoneNumberKind);
        }

        [Fact]
        public void Parse_NonGeographicPhoneNumber()
        {
            var phoneNumber = _parser.Parse("5020000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal("50", nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(_countryInfo, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
            Assert.Equal("20000", nonGeographicPhoneNumber.SubscriberNumber);
            Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, nonGeographicPhoneNumber.PhoneNumberKind);
        }

        [Fact]
        public void Parse_NonGeographicPhoneNumber_Freephone()
        {
            var phoneNumber = _parser.Parse("6028000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal("60", nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(_countryInfo, nonGeographicPhoneNumber.Country);
            Assert.True(nonGeographicPhoneNumber.IsFreephone);
            Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
            Assert.Equal("28000", nonGeographicPhoneNumber.SubscriberNumber);
            Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, nonGeographicPhoneNumber.PhoneNumberKind);
        }

        [Fact]
        public void Parse_NonGeographicPhoneNumber_PremiumRate()
        {
            var phoneNumber = _parser.Parse("7028000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal("70", nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(_countryInfo, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
            Assert.Equal("28000", nonGeographicPhoneNumber.SubscriberNumber);
            Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, nonGeographicPhoneNumber.PhoneNumberKind);
        }
    }
}
