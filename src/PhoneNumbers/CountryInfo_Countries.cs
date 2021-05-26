using System.Collections.ObjectModel;

namespace PhoneNumbers
{
    public partial class CountryInfo
    {
        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Belgium.
        /// </summary>
        public static CountryInfo Belgium { get; } = new()
        {
            CallingCode = "+32",
            Iso3166Code = "BE",
            Name = "Belgium",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2, 1 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 9 }),
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for France.
        /// </summary>
        public static CountryInfo France { get; } = new()
        {
            CallingCode = "+33",
            Iso3166Code = "FR",
            Name = "France",
            NsnLengths = new ReadOnlyCollection<int>(new[] { 9 }),
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Germany.
        /// </summary>
        public static CountryInfo Germany { get; } = new()
        {
            CallingCode = "+49",
            Iso3166Code = "DE",
            Name = "Germany",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 2 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 11, 12 }),
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Guernsey.
        /// </summary>
        public static CountryInfo Guernsey { get; } = new()
        {
            CallingCode = "+44",
            Iso3166Code = "GG",
            Name = "Guernsey",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 4 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
            SharesCallingCode = true,
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Hong Kong.
        /// </summary>
        public static CountryInfo HongKong { get; } = new()
        {
            CallingCode = "+852",
            InternationalCallPrefix = "001",
            Iso3166Code = "HK",
            Name = "Hong Kong",
            NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 9 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Ireland.
        /// </summary>
        /// <remarks>Covers the Republic of Ireland, Northern Ireland is part of the United Kingdom.</remarks>
        public static CountryInfo Ireland { get; } = new()
        {
            CallingCode = "+353",
            Iso3166Code = "IE",
            Name = "Ireland",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2, 1 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 7, 8, 9 }),
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for the Isle of Man.
        /// </summary>
        public static CountryInfo IsleOfMan { get; } = new()
        {
            CallingCode = "+44",
            Iso3166Code = "IM",
            Name = "Isle of Man",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 4 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
            SharesCallingCode = true,
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Italy.
        /// </summary>
        /// <remarks>Covers Italy (includes the islands of Sardinia and Sicily), and Vatican City.</remarks>
        public static CountryInfo Italy { get; } = new()
        {
            CallingCode = "+39",
            Iso3166Code = "IT",
            Name = "Italy",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 5, 4, 3, 2 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 5, 6, 7, 8, 9, 10, 11 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Jersey.
        /// </summary>
        public static CountryInfo Jersey { get; } = new()
        {
            CallingCode = "+44",
            Iso3166Code = "JE",
            Name = "Jersey",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 4 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
            SharesCallingCode = true,
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Macau.
        /// </summary>
        public static CountryInfo Macau { get; } = new()
        {
            CallingCode = "+853",
            Iso3166Code = "MO",
            Name = "Macau",
            NsnLengths = new ReadOnlyCollection<int>(new[] { 8 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Monaco.
        /// </summary>
        public static CountryInfo Monaco { get; } = new()
        {
            CallingCode = "+377",
            Iso3166Code = "MC",
            Name = "Monaco",
            NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 9 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Netherlands.
        /// </summary>
        public static CountryInfo Netherlands { get; } = new()
        {
            CallingCode = "+31",
            Iso3166Code = "NL",
            Name = "Netherlands",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 9 }),
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Portugal.
        /// </summary>
        public static CountryInfo Portugal { get; } = new()
        {
            CallingCode = "+351",
            Iso3166Code = "PT",
            Name = "Portugal",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 3 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 9 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for San Marino.
        /// </summary>
        public static CountryInfo SanMarino { get; } = new()
        {
            CallingCode = "+378",
            Iso3166Code = "SM",
            Name = "San Marino",
            NsnLengths = new ReadOnlyCollection<int>(new[] { 6, 7, 8, 9, 10 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Singapore.
        /// </summary>
        public static CountryInfo Singapore { get; } = new()
        {
            CallingCode = "+65",
            InternationalCallPrefix = "001",
            Iso3166Code = "SG",
            Name = "Singapore",
            NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 10, 11 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Spain.
        /// </summary>
        public static CountryInfo Spain { get; } = new()
        {
            CallingCode = "+34",
            Iso3166Code = "ES",
            Name = "Spain",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 9 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Switzerland.
        /// </summary>
        public static CountryInfo Switzerland { get; } = new()
        {
            CallingCode = "+41",
            Iso3166Code = "CH",
            Name = "Switzerland",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 9 }),
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for the United Kingdom.
        /// </summary>
        /// <remarks>Covers England, Scotland, Wales and Northern Ireland.</remarks>
        public static CountryInfo UnitedKingdom { get; } = new()
        {
            CallingCode = "+44",
            Iso3166Code = "GB",
            Name = "United Kingdom",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 5, 4, 3, 2 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 7, 9, 10 }),
            TrunkPrefix = "0",
        };
    }
}
