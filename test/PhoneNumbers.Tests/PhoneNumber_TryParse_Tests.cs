using Xunit;

namespace PhoneNumbers.Tests
{
    public class PhoneNumber_TryParse_Tests
    {
        [Fact]
        public void TryParse_Value_With_Belgium_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+3250444646", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Belgium, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_France_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+33730334455", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.France, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_Guernsey_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+441481717000", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Guernsey, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_HongKong_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+85251015522", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.HongKong, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_Ireland_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+35340226969", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Ireland, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_IsleOfMan_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+441624696300", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.IsleOfMan, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_Israel_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+97286863100", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Israel, phoneNumber.Country);
        }
        
        [Fact]
        public void TryParse_Value_With_Italy_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+393492525255", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Italy, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_Jersey_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+441534716800", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Jersey, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_Macau_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+85328000000", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Macau, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_Monaco_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+37798988800", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Monaco, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_Netherlands_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+31702140214", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Netherlands, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_Portugal_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+351211140200", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Portugal, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_SanMarino_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+37866661212", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.SanMarino, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_Singapore_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+6530000000", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Singapore, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_Spain_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+34810030000", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Spain, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Value_With_Switzerland_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+41327654321", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Switzerland, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_UnitedKingdom_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+441142726444", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.UnitedKingdom, phoneNumber.Country);
        }
    }
}
