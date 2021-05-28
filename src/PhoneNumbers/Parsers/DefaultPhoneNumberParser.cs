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
    /// ParseAreaAndNumber is overridden or used on its own.
    /// </remarks>
    internal class DefaultPhoneNumberParser : PhoneNumberParser
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="DefaultPhoneNumberParser"/> class.
        /// </summary>
        /// <param name="countryInfo">The <see cref="CountryInfo"/> of the country for the parser.</param>
        /// <param name="countryNumbers">The <see cref="CountryNumber"/>s for the country.</param>
        /// <remarks>The constructor is internal for unit tests only.</remarks>
        internal DefaultPhoneNumberParser(CountryInfo countryInfo, IReadOnlyList<CountryNumber> countryNumbers)
            : base(countryInfo)
            => CountryNumbers = countryNumbers ?? throw new ArgumentNullException(nameof(countryNumbers));

        /// <summary>
        /// Gets the <see cref="CountryNumber"/>s for the country.
        /// </summary>
        protected IReadOnlyList<CountryNumber> CountryNumbers { get; }

        /// <summary>
        /// Creates an instance of the <see cref="DefaultPhoneNumberParser"/> class.
        /// </summary>
        /// <returns>The created <see cref="PhoneNumberParser"/>.</returns>
        internal static PhoneNumberParser Create(CountryInfo countryInfo)
        {
            var countryNumbers = ResourceUtility
                .ReadCountryNumbers($"{countryInfo.Iso3166Code}.txt")
                .ToList()
                .AsReadOnly();

            return new DefaultPhoneNumberParser(countryInfo, countryNumbers);
        }

        /// <summary>
        /// Parses the national dialling code, subscriber number and respective <see cref="CountryNumber"/>.
        /// </summary>
        /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
        protected virtual (string? NationalDiallingCode, string? SubscriberNumber, CountryNumber? CountryNumber) ParseNdcAndSn(string nsnValue)
        {
            string? ndc = null;
            string? sn = null;
            CountryNumber? countryNumber = null;

            if (Country.HasNationalDestinationCodes)
            {
                foreach (var len in Country.NdcLengths)
                {
                    if (len > nsnValue.Length)
                    {
                        continue;
                    }

                    ndc = nsnValue.Substring(0, len);
                    sn = nsnValue.Substring(ndc.Length);

                    countryNumber = CountryNumbers
                        .FirstOrDefault(x =>
                            x.NationalDiallingCodeRanges!.Any(x => x.Contains(ndc)) &&
                            x.SubscriberNumberRanges.Any(x => x.Contains(sn)));

                    if (countryNumber != null)
                    {
                        break;
                    }
                }
            }
            else
            {
                sn = nsnValue;

                countryNumber = CountryNumbers
                    .FirstOrDefault(x => x.SubscriberNumberRanges.Any(x => x.Contains(nsnValue)));
            }

            if (countryNumber != null)
            {
                return (ndc, sn, countryNumber);
            }

            return (null, null, null);
        }

        /// <inheritdoc/>
        /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
        protected override ParseResult ParseNsn(string nsnValue)
        {
            var areaAndNumber = ParseNdcAndSn(nsnValue);

            return (areaAndNumber.CountryNumber?.Kind) switch
            {
                PhoneNumberKind.GeographicPhoneNumber =>
                    ParseResult.Success(
                        new GeographicPhoneNumber(
                            Country,
                            areaAndNumber.CountryNumber.Hint,
                            nsnValue,
                            areaAndNumber.NationalDiallingCode!,
                            areaAndNumber.SubscriberNumber!,
                            areaAndNumber.CountryNumber.GeographicArea!)),

                PhoneNumberKind.MobilePhoneNumber =>
                    ParseResult.Success(
                        new MobilePhoneNumber(
                            Country,
                            areaAndNumber.CountryNumber.Hint,
                            nsnValue,
                            areaAndNumber.NationalDiallingCode,
                            areaAndNumber.SubscriberNumber!)),

                PhoneNumberKind.NonGeographicPhoneNumber =>
                    ParseResult.Success(
                        new NonGeographicPhoneNumber(
                            Country,
                            areaAndNumber.CountryNumber.Hint,
                            nsnValue,
                            areaAndNumber.NationalDiallingCode,
                            areaAndNumber.SubscriberNumber!)),

                _ => base.ParseNsn(nsnValue),
            };
        }
    }
}
