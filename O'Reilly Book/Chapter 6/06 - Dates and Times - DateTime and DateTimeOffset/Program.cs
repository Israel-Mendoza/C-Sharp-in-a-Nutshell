using static System.Console;

/*
    DateTime considers the following two values different, whereas DateTimeOffset considers them equal:
    July 01 2019 09:00:00 +00:00 (GMT)
    July 01 2019 03:00:00 -06:00 (local time, Central America)
*/

//////////////////DATETIME//////////////////

var firstDay = new DateTime();
WriteLine(firstDay);
// 01/01/0001 0:00:00

var myBD = new DateTime(1992, 4, 9, 9, 54, 00, DateTimeKind.Local);
WriteLine(myBD);
// 09/04/1992 9:54:00

var someTime = DateTime.Now - myBD; // TimeSpan object
WriteLine(someTime.TotalDays);
// 11343.387481702963

var randomDateTime = new DateTime(638184793612345678L);
WriteLine(randomDateTime);
// 30/04/2023 19:22:41

var anotherDate = DateTime.Parse("April 9, 1992");
WriteLine(anotherDate);

//////////////////DATETIMEOFFSET//////////////////

/*
    DateTimeOffset has a similar set of constructors. 
    The difference is that you also specify a UTC offset as a TimeSpan.
*/

var myBD2 = new DateTimeOffset(1992, 4, 9, 9, 54, 0, new TimeSpan(-6, 0, 0));
WriteLine(myBD2);
// 09/04/1992 9:54:00 -06:00

//////

myBD2 = myBD2.AddYears(32);
WriteLine(myBD2);
// 09/04/2024 9:54:00 -06:00
myBD2 = myBD2.Subtract(new TimeSpan(100, 0, 0, 0)); // Substracting 100 days
WriteLine(myBD2);
// 31/12/2023 9:54:00 -06:00

var newYearForMe = new DateTime(1992, 4, 9) - new DateTime(1992, 1, 1);
WriteLine(newYearForMe.TotalDays);
// 99

WriteLine(myBD.ToShortDateString());
// 09/04/1992
WriteLine(myBD.ToLongDateString());
// Thursday, 9 April 1992

// For backwards compatibility, use the Min value, for newer versions, use Null

var dt1 = DateTime.MinValue;
DateTime? dt2 = null;

WriteLine(dt1);
// 01/01/0001 0:00:00
WriteLine(dt2?.ToLongDateString());
// 
