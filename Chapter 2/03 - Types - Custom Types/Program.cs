UnitConverter feetToInches = new UnitConverter(12);
UnitConverter milesToFeet = new UnitConverter(5280);

int feet = 5;
int inches = feetToInches.Convert(feet);

int miles = 260;
int feet2 = milesToFeet.Convert(miles);

Console.WriteLine($"{feet} feet equals {inches} inches.");
// 5 feet equals 60 inches.
Console.WriteLine($"{miles} miles equals {feet2} feet.");
// 260 miles equals 1372800 feet.

public class UnitConverter
{
    int ratio; // Field

    public UnitConverter(int unitRatio) // Constructor
    {
        ratio = unitRatio;
    }

    public int Convert(int unit) // Method
    {
        return unit * ratio;
    }
}