using System.Collections.ObjectModel;
using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="LocalOnlyPhoneNumberParser"/> class.
    /// </summary>
    public class LocalOnlyPhoneNumberParserTests
    {
        private readonly CountryInfo _countryInfo = TestHelper.CreateCountryInfo(false, new[] { 5 });
        private readonly PhoneNumberParser _parser;

        public LocalOnlyPhoneNumberParserTests()
        {
            _parser = new LocalOnlyPhoneNumberParser(
                _countryInfo,
                new[]
                {
                new LocalNumberInfo
                {
                    LocalNumberRanges = new [] { NumberRange.Create("10000-10999") },
                    Kind = PhoneNumberKind.MobilePhoneNumber,
                    Hint = Hint.None,
                },
                new LocalNumberInfo
                {
                    LocalNumberRanges = new [] { NumberRange.Create("11000-11999") },
                    Kind = PhoneNumberKind.MobilePhoneNumber,
                    Hint = Hint.Data,
                },
                new LocalNumberInfo
                {
                    LocalNumberRanges = new [] { NumberRange.Create("12000-12999") },
                    Kind = PhoneNumberKind.MobilePhoneNumber,
                    Hint = Hint.Pager,
                },
                new LocalNumberInfo
                {
                    LocalNumberRanges = new [] { NumberRange.Create("13000-13999") },
                    Kind = PhoneNumberKind.MobilePhoneNumber,
                    Hint = Hint.Virtual,
                },
                new LocalNumberInfo
                {
                    LocalNumberRanges = new [] { NumberRange.Create("20000-20999") },
                    Kind = PhoneNumberKind.NonGeographicPhoneNumber,
                    Hint = Hint.None,
                },
                new LocalNumberInfo
                {
                    LocalNumberRanges = new [] { NumberRange.Create("28000-28999") },
                    Kind = PhoneNumberKind.NonGeographicPhoneNumber,
                    Hint = Hint.Freephone,
                },
                });
        }

        [Fact]
        public void Parse_Invalid_Number() =>
            Assert.Equal("05500 is not a valid ZZ phone number.", _parser.Parse("05500").ParseError);

        [Fact]
        public void Parse_MobilePhoneNumber()
        {
            var phoneNumber = _parser.Parse("10000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Null(mobilePhoneNumber.AreaCode);
            Assert.Equal(_countryInfo, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal("10000", mobilePhoneNumber.LocalNumber);
            Assert.Equal(PhoneNumberKind.MobilePhoneNumber, mobilePhoneNumber.PhoneNumberKind);
        }

        [Fact]
        public void Parse_MobilePhoneNumber_Data()
        {
            var phoneNumber = _parser.Parse("11000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Null(mobilePhoneNumber.AreaCode);
            Assert.Equal(_countryInfo, mobilePhoneNumber.Country);
            Assert.True(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal("11000", mobilePhoneNumber.LocalNumber);
            Assert.Equal(PhoneNumberKind.MobilePhoneNumber, mobilePhoneNumber.PhoneNumberKind);
        }

        [Fact]
        public void Parse_MobilePhoneNumber_Pager()
        {
            var phoneNumber = _parser.Parse("12000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Null(mobilePhoneNumber.AreaCode);
            Assert.Equal(_countryInfo, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.True(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal("12000", mobilePhoneNumber.LocalNumber);
            Assert.Equal(PhoneNumberKind.MobilePhoneNumber, mobilePhoneNumber.PhoneNumberKind);
        }

        [Fact]
        public void Parse_MobilePhoneNumber_Virtual()
        {
            var phoneNumber = _parser.Parse("13000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Null(mobilePhoneNumber.AreaCode);
            Assert.Equal(_countryInfo, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.True(mobilePhoneNumber.IsVirtual);
            Assert.Equal("13000", mobilePhoneNumber.LocalNumber);
            Assert.Equal(PhoneNumberKind.MobilePhoneNumber, mobilePhoneNumber.PhoneNumberKind);
        }

        [Fact]
        public void Parse_NonGeographicPhoneNumber()
        {
            var phoneNumber = _parser.Parse("20000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Null(nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(_countryInfo, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal("20000", nonGeographicPhoneNumber.LocalNumber);
            Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, nonGeographicPhoneNumber.PhoneNumberKind);
        }

        [Fact]
        public void Parse_NonGeographicPhoneNumber_Freephone()
        {
            var phoneNumber = _parser.Parse("28000").PhoneNumber;
            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Null(nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(_countryInfo, nonGeographicPhoneNumber.Country);
            Assert.True(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal("28000", nonGeographicPhoneNumber.LocalNumber);
            Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, nonGeographicPhoneNumber.PhoneNumberKind);
        }
    }
}