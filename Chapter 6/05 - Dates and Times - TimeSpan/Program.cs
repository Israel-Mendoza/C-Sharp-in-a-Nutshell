using static System.Console;

///////////////USING CONSTRUCTOR///////////////

var ts1 = new TimeSpan(0, 0, 5); // 5 seconds
var ts2 = new TimeSpan(50_000_000); // 5 seconds (1 tick = 100ns)

///////////////USING FROM-CONSTRUCTOR///////////////

var ts3 = TimeSpan.FromSeconds(5); // 5 seconds
var ts4 = TimeSpan.FromMinutes(0.08333333333); // 5 seconds
var ts5 = TimeSpan.FromMilliseconds(5000); // 5 seconds
var ts6 = TimeSpan.FromMicroseconds(5000000); // 5 seconds

WriteLine(ts1);
// 00:00:05
WriteLine(ts2);
// 00:00:05
WriteLine(ts3);
// 00:00:05
WriteLine(ts4);
// 00:00:04.9999999
WriteLine(ts5);
// 00:00:05
WriteLine(ts6);
// 00:00:05

var TwoHoursAndAHalf = TimeSpan.FromHours(2) + TimeSpan.FromMinutes(30);
WriteLine(TwoHoursAndAHalf);
// 02:30:00

var NearlyTenDays = TimeSpan.FromDays(10) - TimeSpan.FromMinutes(24) - TimeSpan.FromSeconds(29);
WriteLine(NearlyTenDays);
// 9.23:35:31
WriteLine(NearlyTenDays.Days);
// 9
WriteLine(NearlyTenDays.Hours);
// 23
WriteLine(NearlyTenDays.Minutes);
// 35
WriteLine(NearlyTenDays.Seconds);
// 31

WriteLine(NearlyTenDays.TotalDays);
// 9.982997685185186
WriteLine(NearlyTenDays.TotalHours);
// 239.59194444444444
WriteLine(NearlyTenDays.TotalMinutes);
// 14375.516666666666
WriteLine(NearlyTenDays.TotalSeconds);
// 862531