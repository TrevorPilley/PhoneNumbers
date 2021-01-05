using System.Collections.ObjectModel;

namespace PhoneNumbers.Tests
{
    internal static class TestHelper
    {
        internal static CountryInfo CreateCountryInfo(bool hasAreaCodes, int[] nsnLengths) =>
            new CountryInfo
            {
                CallingCode = "+422", // +422 isn't a used calling code.
                HasAreaCodes = hasAreaCodes,
                Iso3116Code = "ZZ", // ZZ isn't a used ISO 3116 code.
                NsnLengths = new ReadOnlyCollection<int>(nsnLengths),
            };
    }
}