bool isRainy = false;
bool isSunny = true;
bool isWindy = true;

if (UseUmbrella(isRainy, isSunny, isWindy)) {
    Console.WriteLine("I forgot the fucking umbrella");
} else {
    Console.WriteLine("Thank God it didn't rain! I fotgot the umbrella again.");
}

// Ternary operator

Console.WriteLine($"It is {(isRainy ? "" : "not")} raining!");
// It is not raining!

bool UseUmbrella(bool isRainy, bool isSunny, bool isWindy) {
    return !isWindy && (isRainy || isSunny);
}

