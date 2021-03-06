using System;

namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> which returns the E.123 international format.
    /// </summary>
    internal sealed class E123PhoneNumberFormatter : PhoneNumberFormatter
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="E123PhoneNumberFormatter"/> class.
        /// </summary>
        private E123PhoneNumberFormatter()
        {
        }

        /// <summary>
        /// Gets the <see cref="E123PhoneNumberFormatter"/> instance.
        /// </summary>
        internal static PhoneNumberFormatter Instance { get; } = new E123PhoneNumberFormatter();

        /// <inheritdoc/>
        public override bool CanFormat(string format) =>
            format?.Equals("E.123", StringComparison.Ordinal) == true;

        /// <inheritdoc/>
        public override string Format(PhoneNumber phoneNumber) =>
            phoneNumber!.NationalDestinationCode is not null
                ? $"{phoneNumber.Country.CallingCode} {phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber}"
                : $"{phoneNumber.Country.CallingCode} {phoneNumber.SubscriberNumber}";
    }
}
