using static System.Console;

var localTime = DateTimeOffset.Now;
var utcTime = localTime.ToUniversalTime();

WriteLine(localTime);
// 30/04/2023 20:37:59 -06:00
WriteLine(utcTime);
// 01/05/2023 2:37:59 +00:00

WriteLine(localTime.Offset);
WriteLine(utcTime.Offset);
// -06:00:00
// 00:00:00 

////////////////////TIMEZONEINFO////////////////////

var tz = TimeZoneInfo.Local;
WriteLine(tz);
// (UTC-06:00) Central Time (Mexico City)
WriteLine(tz.StandardName);
// Central Standard Time
WriteLine(tz.DaylightName);
// Central Daylight Time

// Possible TimeZones are found under:
var possibleTZs = TimeZoneInfo.GetSystemTimeZones();

foreach (var t in possibleTZs)
{
    WriteLine($"{t} - ID: {t.Id}");
}
// (UTC-11:00) Niue Time - ID: Pacific/Niue
// (UTC-11:00) Samoa Standard Time (Midway) - ID: Pacific/Midway
// (UTC-11:00) Samoa Standard Time (Pago Pago) - ID: Pacific/Pago_Pago
// (UTC-10:00) Cook Islands Standard Time (Rarotonga) - ID: Pacific/Rarotonga
// (UTC-10:00) Hawaii-Aleutian Time (Adak) - ID: America/Adak
// .
// .
// .

var RioTZ = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");

WriteLine(RioTZ.DisplayName);
// (UTC-03:00) Brasilia Standard Time (Sao Paulo)
WriteLine(RioTZ.BaseUtcOffset);
// -03:00:00
WriteLine(RioTZ.SupportsDaylightSavingTime);
// True
