interface FlightEnabled
{
    // We don't need the "public" and "abstract" modifiers, 
    // because they are "implied" for an interface.
    // Interfaces cannot have concrete methods. 
    // Declaring CONSTANTS is possible as well.
    static double MILES_TO_KM = 1.60934;
    static double KM_TO_MILES = 0.621371;
    void TakeOff();
    void Fly();
    void Land();
}

interface OrbitEarth : FlightEnabled
{
    void AchieveOrbit();
}

interface Trackable
{
    void Track();
}

public abstract class Animal
{
    public abstract void Move();
}