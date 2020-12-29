using System;

namespace PhoneNumbers
{
    /// <summary>
    /// An implementation of <see cref="PhoneNumber"/> which represents a geographicly assigned phone number.
    /// </summary>
    public sealed class GeographicPhoneNumber : PhoneNumber, IEquatable<GeographicPhoneNumber>
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="GeographicPhoneNumber"/> class.
        /// </summary>
        /// <param name="countryInfo">The <see cref="CountryInfo"/> for the phone number.</param>
        /// <param name="areaCode">The area code of the phone number.</param>
        /// <param name="localNumber">The local number of the phone number.</param>
        /// <param name="geographicArea">The name of the geographic area the phone number the area code is allocated to.</param>
        internal GeographicPhoneNumber(
            CountryInfo countryInfo,
            string areaCode,
            string localNumber,
            string geographicArea)
            : base(countryInfo, areaCode, localNumber) =>
            GeographicArea = geographicArea;

        /// <summary>
        /// Gets the name of the geographic area the phone number the area code is allocated to.
        /// Depending on the country, this could be an individual city or larger region such as a county.
        /// </summary>
        public string GeographicArea { get; }

        /// <inheritdoc/>
        public override PhoneNumberKind PhoneNumberKind =>
            PhoneNumberKind.GeographicPhoneNumber;

        /// <inheritdoc/>
        public static bool operator !=(GeographicPhoneNumber? phoneNumber1, GeographicPhoneNumber? phoneNumber2) =>
            !(phoneNumber1 == phoneNumber2);

        /// <inheritdoc/>
        public static bool operator ==(GeographicPhoneNumber? phoneNumber1, GeographicPhoneNumber? phoneNumber2)
        {
            if (phoneNumber1 is null)
            {
                return phoneNumber2 is null;
            }

            return phoneNumber1.Equals(phoneNumber2);
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj) =>
            Equals(obj as GeographicPhoneNumber);

        /// <inheritdoc/>
        public bool Equals(GeographicPhoneNumber? other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return (AreaCode == null && other.AreaCode == null || AreaCode!.Equals(other.AreaCode, StringComparison.Ordinal)) &&
                Country.Equals(other.Country) &&
                GeographicArea.Equals(other.GeographicArea, StringComparison.Ordinal) &&
                LocalNumber.Equals(other.LocalNumber, StringComparison.Ordinal) &&
                PhoneNumberKind.Equals(other.PhoneNumberKind);
        }

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public override int GetHashCode() =>
            HashCode.Combine(AreaCode, Country, GeographicArea, LocalNumber, PhoneNumberKind);
    }
}
