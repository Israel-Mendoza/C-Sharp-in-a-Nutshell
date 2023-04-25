// Generic Methods

string FirstName = "Israel";
string LastName = "Mendoza";
int MoonLanding = 1969;
int CovidPandemic = 2020;

Console.WriteLine($"{FirstName} {LastName}");
Console.WriteLine($"Moonlanding: {MoonLanding} - Covid Pandemic: {CovidPandemic}");
// Israel Mendoza
// Moonlanding: 1969 - Covid Pandemic: 2020

Swap(ref FirstName, ref LastName); // Swapping strings.
Swap(ref MoonLanding, ref CovidPandemic);

Console.WriteLine($"{FirstName} {LastName}");
Console.WriteLine($"Moonlanding: {MoonLanding} - Covid Pandemic: {CovidPandemic}");
// Mendoza Israel
// Moonlanding: 2020 - Covid Pandemic: 1969


void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}
