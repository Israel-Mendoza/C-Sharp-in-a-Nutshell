// IF - ELSE IF - ELSE

TellMeWhatCanIDo(32);
// You can drink!
TellMeWhatCanIDo(19);
// You can vote.
TellMeWhatCanIDo(16);
// You can wait!

// SWITCH STATEMENT
/*
Since C#7, we can test based on type. See function "TellMeWhatThisIs".
*/

var LOTR = 5;
var HP = 3;
var StarWars = 2;
var Marlow = 1;

StreamItOrSkipIt(LOTR);
// What are you doing reading this? Go watch the fucking movie!
StreamItOrSkipIt(HP);
// Watch it, just for the sake of it.
StreamItOrSkipIt(StarWars);
// You got anything else better to do righ now?
StreamItOrSkipIt(Marlow);
// You better go out for a walk.

var myAge = 31;
var myName = "Israel";
var isHandsome = true;
var heightInMeters = 1.76;

TellMeWhatThisIs(myAge);
// Can't you recognize this? '31' is a freaking integer!
TellMeWhatThisIs(myName);
// Well... I can tell you can't read. This is a string.
TellMeWhatThisIs(isHandsome);
// This is a boolean. I'll explain later.
TellMeWhatThisIs(heightInMeters);
// I don't know what '1.76' is.

var aFloat = 3.141592F;
var aDouble = 999.9;
var aDecimal = 123456.123456M;

getBigDecimals(aFloat);
//
getBigDecimals(aDouble);
//
getBigDecimals(aDecimal);
// We found a big decimal number, but we don't know its type.

void TellMeWhatCanIDo(int yourAge) {
    if (yourAge >= 35)
        Console.WriteLine("You can become president");
    else if (yourAge >= 21)
        Console.WriteLine("You can drink!");
    else if (yourAge >= 18)
        Console.WriteLine("You can vote.");
    else
        Console.WriteLine("You can wait!");
}

void StreamItOrSkipIt(int rating) {
    switch (rating) {
        case 1:
            Console.WriteLine("You better go out for a walk.");
            break;
        case 2:
            Console.WriteLine("You got anything else better to do righ now?");
            break;
        case 3:
        case 4:
            Console.WriteLine("Watch it, just for the sake of it.");
            break;
        case 5:
            Console.WriteLine("What are you doing reading this? Go watch the fucking movie!");
            break;
        default:
            Console.WriteLine("Movies? I don't know WTF you're talking about.");
            break;
    }
}

void TellMeWhatThisIs(object anything) {
    switch (anything) {
        case int i:
            Console.WriteLine($"Can't you recognize this? '{anything}' is a freaking integer!");
            break;
        case string s:
            Console.WriteLine($"Well... I can tell you can't read. This is a string.");
            break;
        case bool b:
            Console.WriteLine($"This is a boolean. I'll explain later.");
            break;
        default:
            Console.WriteLine($"I don't know what '{anything}' is.");
            break;
    }
}

void getBigDecimals(object aNumber) {
    switch (aNumber) {
        case float f when f > 1000:
        case double d when d > 1000:
        case decimal m when m > 1000:
            Console.WriteLine ("We found a big decimal number, but we don't know its type.");
        break;
    }
}