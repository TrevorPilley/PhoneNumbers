# PhoneNumbers

A library for parsing phone numbers, built for .NET 5.0, .NET Standard 2.1 and .NET Standard 2.0 using [nullable reference type](https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references) annotations.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/TrevorPilley/PhoneNumbers/blob/main/LICENSE) ![GitHub last commit](https://img.shields.io/github/last-commit/TrevorPilley/PhoneNumbers/main) ![Build Status](https://github.com/TrevorPilley/PhoneNumbers/workflows/CI/badge.svg?branch=main) ![CodeQL](https://github.com/TrevorPilley/PhoneNumbers/workflows/CodeQL/badge.svg) [![NuGet](https://img.shields.io/nuget/v/PhoneNumberParser.svg)](https://www.nuget.org/packages/PhoneNumberParser/) [![PhoneNumberParser on fuget.org](https://www.fuget.org/packages/PhoneNumberParser/badge.svg)](https://www.fuget.org/packages/PhoneNumberParser) ![GitHub Release Date](https://img.shields.io/github/release-date/TrevorPilley/PhoneNumbers) [![NuGet](https://img.shields.io/nuget/dt/PhoneNumberParser.svg)](https://www.nuget.org/packages/PhoneNumberParser/)

The library provides a number of improvements over a regular expression, for example greater validity of phone numbers including the validity of national desination codes (area codes) and subscriber numbers. Additional attribues such as the kind of phone number (Mobile, Geographic or Non-Geographic). All parsing is performed locally within the library using embedded in-memory data files.

The library **does not**:

- Provide certainty that a phone number is assigned and in use
- Provide the carrier for mobile phone numbers (due to number portability in most countries the accuracy of this is uncertain)
- Support extension numbers

## Install

Install via nuget:

```bash
dotnet add package PhoneNumberParser
```

Add the namespace:

```csharp
using PhoneNumbers;
```

## Parsing

Parsing a phone number is achieved via the `PhoneNumber.Parse` method (or alternatively or `PhoneNumber.TryParse`). Any spaces, hyphens or other formatting in the input string is ignored.

There are 2 overloads:

```csharp
// If the phone number string is in international format (e.g. +XX):
PhoneNumber phoneNumber = PhoneNumber.Parse("+441142726444");

// If the phone number string is not in international format:
// Specify the ISO 3166 Alpha-2 code for the country as the second parameter.
PhoneNumber phoneNumber = PhoneNumber.Parse("01142726444", "GB");
```

The resulting `PhoneNumber` has the following properties:

```csharp
// PhoneNumber properties:
phoneNumber.Country.CallingCode;                // +44
phoneNumber.Country.InternationalCallPrefix;    // 00
phoneNumber.Country.Iso3166Code;                // GB
phoneNumber.Country.Name;                       // United Kingdom
phoneNumber.Country.TrunkPrefix;                // 0
phoneNumber.NationalDiallingCode;               // 114
phoneNumber.NationalSignificantNumber           // 1142726444
phoneNumber.SubscriberNumber                    // 2726444
phoneNumber.PhoneNumberKind;                    // PhoneNumberKind.GeographicPhoneNumber

// PhoneNumberKind - can be used to determine the type of PhoneNumber to cast to
GeographicPhoneNumber,
MobilePhoneNumber,
NonGeographicPhoneNumber,

// If PhoneNumberKind.GeographicPhoneNumber
var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
geographicPhoneNumber.GeographicArea;           // Sheffield

// If PhoneNumberKind.MobilePhoneNumber
var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
mobilePhoneNumber.IsDataOnly;                   // true/false
mobilePhoneNumber.IsPager;                      // true/false
mobilePhoneNumber.IsVirtual;                    // true/false

// If PhoneNumberKind.NonGeographicPhoneNumber
var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
nonGeographicPhoneNumber.IsFreephone;           // true/false
nonGeographicPhoneNumber.IsPremiumRate;         // true/false
```

The phone number can be formatted in the following ways, the default format output can be round tripped via `PhoneNumber.Parse()` to make serialization or database persistence straightforward.

```csharp
phoneNumber.ToString();                         // +441142726444   (defaults to E.164 format)
phoneNumber.ToString("E.164");                  // +441142726444   (format for E.164 format)
phoneNumber.ToString("E.123");                  // +44 114 2726444 (format for E.123 format)
phoneNumber.ToString("N");                      // 01142726444     (format for National format)
```

### ParseOptions

The `ParseOptions` class can be used to control parsing, the defaults can be configured via.

```csharp
ParseOptions.Default
```

At present, the only options available are which countries are parsed.

By default all countries supported by the library can be parsed and any future supported ones will be included.

#### Opt-in

To opt in to specific countries and ignore any new ones added in future versions of the library:

```csharp
ParseOptions.Default.Countries.Clear():
ParseOptions.Default.Countries.Add(CountryInfo.X);
```

#### Opt-out

To out out of specific countries but still use any new ones added in future versions of the library:

```csharp
ParseOptions.Default.Countries.Remove(CountryInfo.X);
```

## Country support

The library currently supports parsing phone numbers for the following countries and although best endeavours are made to adhere to published telephone numbering plans, depending on the accessibility of data there may be discrepancies. If you happen to find any, please raise a bug.

Country        | ISO 3166 Code | Calling Code | Trunk Prefix | Geographic | Mobile | Mobile<br/>(Data Only) | Mobile<br/>(Pager) | Mobile<br/>(Virtual) | Non-Geographic | Non-Geographic<br/>(Freephone)| Non-Geographic<br/>(Premium Rate)
---            | ---           | ---          | ---          | :-:        | :-:    | :-:                    | :-:                | :-:                  | :-:            | :-:                           | :-:
Belgium        | BE            | +32          | 0            | Yes        | Yes    |                        |                    |                      | Yes            | Yes                           | Yes
France         | FR            | +33          | 0            | Yes        | Yes    |                        |                    |                      | Yes            | Yes                           | Yes
Germany        | DE            | +49          | 0            |            |        |                        |                    |                      |                |                               |
Guernsey       | GG            | +44          | 0            | Yes        | Yes    |                        |                    |                      |                |                               |
Hong Kong      | HK            | +852         |              |            | Yes    |                        |                    | Yes                  | Yes            | Yes                           |
Ireland        | IE            | +353         | 0            | Yes        | Yes    |                        | Yes                | Yes                  | Yes            | Yes                           | Yes
Isle of Man    | IM            | +44          | 0            | Yes        | Yes    |                        |                    |                      |                |                               |
Italy          | IT            | +39          |              | Yes        | Yes    |                        |                    |                      | Yes            | Yes                           | Yes
Jersey         | JE            | +44          | 0            | Yes        | Yes    |                        |                    |                      |                |                               |
Macau          | MO            | +853         |              |            | Yes    |                        |                    |                      | Yes            |                               |
Monaco         | MC            | +377         |              |            | Yes    |                        |                    |                      | Yes            |                               |
Netherlands    | NL            | +31          | 0            | Yes        | Yes    |                        | Yes                |                      | Yes            | Yes                           | Yes
Portugal       | PT            | +351         |              | Yes        | Yes    |                        |                    | Yes                  | Yes            | Yes                           | Yes
San Marino     | SM            | +378         |              | Yes        |        |                        |                    |                      | Yes            |                               | Yes
Singapore      | SG            | +65          |              |            | Yes    |                        |                    |                      | Yes            | Yes                           | Yes
Spain          | ES            | +34          |              | Yes        | Yes    |                        |                    | Yes                  | Yes            | Yes                           | Yes
Switzerland    | CH            | +41          | 0            | Yes        | Yes    |                        |                    |                      | Yes            |                               | Yes
United Kingdom | GB            | +44          | 0            | Yes        | Yes    | Yes                    | Yes                | Yes                  | Yes            | Yes                           | Yes

### Notes

- The ISO code for the United Kingdom is 'GB' rather than 'UK'.
- Geographically assigned numbers in France are currently only within the top level geographic zones (01 Île-de-France, 02 Nord-Ouest, 03 Nord-Est, 04 Sud-Est and 05 Sud-Ouest).
- Where possible, the geograpic area name is in the language/locality of the country for the phone number (e.g. for an Italian phone number assigned to Florence, the gaographic area will be set to `Firenze`.

## References for number data

These were used as the references for the phone number data for each country.

### Belgium

- https://www.bipt.be/operators/publication/national-numbering-plan
- https://www.bipt.be/operators/publication/database-with-reserved-and-allocated-numbers
- https://en.wikipedia.org/wiki/Telephone_numbers_in_Belgium

### France

- https://www.itu.int/dms_pub/itu-t/oth/02/02/T020200004A0002PDFE.pdf
- https://fr.wikipedia.org/wiki/Liste_des_indicatifs_téléphoniques_en_France
- https://en.wikipedia.org/wiki/Telephone_numbers_in_France

### Hong Kong

- https://www.ofca.gov.hk/filemanager/ofca/tc/content_311/no_plan.pdf
- https://www.ofca.gov.hk/mobile/en/consumer_focus/education_corner/guide/advice_lfs/ipts/
- https://en.wikipedia.org/wiki/Telephone_numbers_in_Hong_Kong

### Ireland

- https://www.comreg.ie/industry/licensing/numbering/area-code-maps-2/
- https://www.comreg.ie/csv/downloads/ComReg0804.pdf
- https://www.itu.int/dms_pub/itu-t/oth/02/02/T02020000680001PDFE.pdf
- https://en.wikipedia.org/wiki/Telephone_numbers_in_the_Republic_of_Ireland

### Italy

- https://www.itu.int/dms_pub/itu-t/oth/02/02/T020200006B0001PDFE.pdf
- https://en.wikipedia.org/wiki/Telephone_numbers_in_Italy

### Macau

- https://en.wikipedia.org/wiki/Telephone_numbers_in_Macau

### Monaco

- https://www.itu.int/dms_pub/itu-t/oth/02/02/T020200008D0008PDFE.pdf

### Netherlands

- https://www.government.nl/documents/annual-reports/2016/02/16/numbering-plan-telephony-and-isdn-services
- https://en.wikipedia.org/wiki/Telephone_numbers_in_the_Netherlands

### Portugal

- https://en.wikipedia.org/wiki/Telephone_numbers_in_Portugal

### San Marino

- https://www.itu.int/dms_pub/itu-t/oth/02/02/T02020000B50001PDFE.pdf

### Singapore

- https://www.imda.gov.sg/-/media/Imda/Files/Regulation-Licensing-and-Consultations/Frameworks-and-Policies/Numbering/National-Numbering-Plan-and-Allocation-Process/IMDA-National-Numbering-Plan-12-Aug-2019.pdf?la=en
- https://en.wikipedia.org/wiki/Telephone_numbers_in_Singapore

### Spain

- https://avancedigital.mineco.gob.es/es-ES/Servicios/Numeracion/Documents/Descripcion_PNN.pdf
- https://numeracionyoperadores.cnmc.es/numeracion
- https://en.wikipedia.org/wiki/Telephone_numbers_in_Spain

### Switzerland

- https://www.bakom.admin.ch/bakom/en/homepage/telecommunication/numbering-and-telephony/number-blocks-and-codes.html
- https://en.wikipedia.org/wiki/Telephone_numbers_in_Switzerland

### United Kingdom, Guernsey, Jersey, Isle of Man

- https://www.area-codes.org.uk/
- https://www.itu.int/dms_pub/itu-t/oth/02/02/T02020000DD0001PDFE.pdf
- http://static.ofcom.org.uk/static/numbering/index.htm
- https://www.ofcom.org.uk/__data/assets/pdf_file/0013/102613/national-numbering-plan.pdf
- https://en.wikipedia.org/wiki/Telephone_numbers_in_the_United_Kingdom
