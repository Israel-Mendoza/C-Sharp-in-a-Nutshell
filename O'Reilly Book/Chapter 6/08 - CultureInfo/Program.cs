using System.Globalization;
using static System.Console;

var diffCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

foreach (var culture in diffCultures)
{
    WriteLine($"Name: {culture.Name} - LCID: {culture.LCID}");
}
// .
// .
// .
// Name: en-NL - LCID: 4096
// Name: en-NO - LCID: 4096
// Name: en-NR - LCID: 4096
// Name: en-NU - LCID: 4096
// Name: en-NZ - LCID: 5129
// .
// .
// .

var br = CultureInfo.GetCultureInfo("pt-BR");
var mx = CultureInfo.GetCultureInfo("es-MX");
var uk = CultureInfo.GetCultureInfo("en-GB");

var value = 3.50;
WriteLine(value.ToString("C", br));
// R$ 3,50
WriteLine(value.ToString("C", mx));
// $3.50
WriteLine(value.ToString("C", uk));
// £3.50
