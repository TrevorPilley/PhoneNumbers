using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneNumbers.Parsers
{
    /// <summary>
    /// The default <see cref="PhoneNumberParser"/>.
    /// </summary>
    /// <remarks>
    /// Depending on the complexity of the country phone numbering, this can be a base class where
    /// ParseAreaAndNumber is overriden or used on its own.
    /// </remarks>
    internal class DefaultPhoneNumberParser : PhoneNumberParser
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="DefaultPhoneNumberParser"/> class.
        /// </summary>
        /// <remarks>The constructor is internal for unit tests only.</remarks>
        internal DefaultPhoneNumberParser(CountryInfo countryInfo, IReadOnlyList<CountryNumber> countryNumbers)
            : base(countryInfo)
            => CountryNumbers = countryNumbers ?? throw new ArgumentNullException(nameof(countryNumbers));

        protected IReadOnlyList<CountryNumber> CountryNumbers { get; }

        /// <summary>
        ///     Creates an instance of the <see cref="DefaultPhoneNumberParser"/> class.
        /// </summary>
        /// <returns>The created <see cref="PhoneNumberParser"/>.</returns>
        internal static PhoneNumberParser Create(CountryInfo countryInfo)
        {
            var countryNumbers = ResourceUtility
                .ReadCountryNumbers($"{countryInfo.Iso3116Code}_numbers.txt")
                .ToList()
                .AsReadOnly();

            return new DefaultPhoneNumberParser(countryInfo, countryNumbers);
        }

        /// <summary>
        /// Parses the area code, local number and respective <see cref="CountryNumber"/>.
        /// </summary>
        /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
        protected virtual (string? AreaCode, string? LocalNumber, CountryNumber? CountryNumber) ParseAreaAndNumber(string nsnValue)
        {
            string? areaCode = null;
            string? localNumber = null;
            CountryNumber? countryNumber = null;

            if (Country.HasAreaCodes)
            {
                foreach (var len in Country.AreaCodeLengths)
                {
                    areaCode = nsnValue.Substring(0, len);
                    localNumber = nsnValue.Substring(areaCode.Length);

                    countryNumber = CountryNumbers
                        .SingleOrDefault(x =>
                            x.AreaCodeRanges!.Any(x => x.Contains(areaCode)) &&
                            x.LocalNumberRanges.Any(x => x.Contains(localNumber)));

                    if (countryNumber != null)
                    {
                        break;
                    }
                }
            }
            else
            {
                localNumber = nsnValue;

                countryNumber = CountryNumbers
                    .SingleOrDefault(x => x.LocalNumberRanges.Any(x => x.Contains(nsnValue)));
            }

            if (countryNumber != null)
            {
                return (areaCode, localNumber, countryNumber);
            }

            return (null, null, null);
        }

        /// <inheritdoc/>
        /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
        protected override ParseResult ParseNationalSignificantNumber(string nsnValue)
        {
            var x = ParseAreaAndNumber(nsnValue);

            if (x.CountryNumber != null)
            {
                switch (x.CountryNumber.Kind)
                {
                    case PhoneNumberKind.GeographicPhoneNumber:
                        return ParseResult.Success(
                            new GeographicPhoneNumber(Country, x.AreaCode!, x.LocalNumber!,
                                x.CountryNumber.GeographicArea!));

                    case PhoneNumberKind.MobilePhoneNumber:
                        var isDataOnly = x.CountryNumber.Hint == Hint.Data;
                        var isPager = x.CountryNumber.Hint == Hint.Pager;
                        var isVirtual = x.CountryNumber.Hint == Hint.Virtual;

                        return ParseResult.Success(
                            new MobilePhoneNumber(Country, x.AreaCode, x.LocalNumber!, isDataOnly, isPager, isVirtual));

                    case PhoneNumberKind.NonGeographicPhoneNumber:
                        var isFreephone = x.CountryNumber.Hint == Hint.Freephone;

                        return ParseResult.Success(
                            new NonGeographicPhoneNumber(Country, x.AreaCode, x.LocalNumber!, isFreephone));
                }
            }

            return base.ParseNationalSignificantNumber(nsnValue);
        }
    }
}