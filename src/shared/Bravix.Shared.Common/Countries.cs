using ISO3166;

namespace Bravix.Shared.Common;

public static class Countries
{
    private static readonly Dictionary<string, Country> _countries = 
        Country.List.ToDictionary(x => x.TwoLetterCode);

    public static Country GetCountry(string twoLetterCode) => _countries[twoLetterCode];
    
    public static Country[] All => _countries.Values.ToArray();
}