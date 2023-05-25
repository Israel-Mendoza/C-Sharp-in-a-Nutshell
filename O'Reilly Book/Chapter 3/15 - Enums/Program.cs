
Console.WriteLine(Months.January);
// January

var month_0 = (int)Months.January;
var month_1 = (int)Months.February;
var month_2 = (int)Months.March;
var month_3 = (int)Months.April;
var month_4 = (int)Months.May;
var month_5 = (int)Months.June;
var month_6 = (int)Months.July;
var month_7 = (int)Months.August;
var month_8 = (int)Months.September;
var month_9 = (int)Months.October;
var month_10 = (int)Months.November;
var month_11 = (int)Months.December;

Console.WriteLine(month_0);
// 1
Console.WriteLine(month_1);
// 2
Console.WriteLine(month_2);
// 3
Console.WriteLine(month_3);
// 4
Console.WriteLine(month_4);
// 5
Console.WriteLine(month_5);
// 16
Console.WriteLine(month_6);
// 17
Console.WriteLine(month_7);
// 18
Console.WriteLine(month_8);
// 19
Console.WriteLine(month_9);
// 20
Console.WriteLine(month_10);
// 21
Console.WriteLine(month_11);

Months myMonth = Months.April;

if ((int)myMonth == 4)
    Console.WriteLine("You're month is the best! April!");
// You're month is the best! April!

enum Months
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July = 16,
    August,
    September,
    October,
    November,
    December
}