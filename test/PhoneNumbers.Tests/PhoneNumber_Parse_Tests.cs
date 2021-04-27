using Xunit;

namespace PhoneNumbers.Tests
{
    public class PhoneNumber_Parse_Tests
    {
        [Fact]
        public void Parse_Value_With_Belgium_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+3250444646");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Belgium, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_France_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+33730334455");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.France, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Guernsey_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+441481717000");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Guernsey, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_HongKong_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+85251015522");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.HongKong, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Ireland_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+35340226969");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Ireland, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_IsleOfMan_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+441624696300");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.IsleOfMan, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Israel_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+97286863100");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Israel, phoneNumber.Country);
        }
        
        [Fact]
        public void Parse_Value_With_Italy_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+393492525255");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Italy, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Jersey_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+441534716800");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Jersey, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Macau_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+85328000000");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Macau, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Monaco_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+37798988800");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Monaco, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Netherlands_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+31702140214");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Netherlands, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Portugal_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+351211140200");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Portugal, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_SanMarino_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+37866661212");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.SanMarino, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Singapore_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+6530000000");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Singapore, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Spain_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+34810030000");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Spain, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Switzerland_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+41327654321");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Switzerland, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_UnitedKingdom_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+441142726444");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.UnitedKingdom, phoneNumber.Country);
        }
    }
}
