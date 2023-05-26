public class Bird : Animal, FlightEnabled, Trackable
{
    public override void Move() => Console.WriteLine($"The {this.GetType()} laps its wings...");
    public void Fly() => Console.WriteLine($"{this.GetType()} is flying!");
    public void Land() => Console.WriteLine($"The {this.GetType()} is landing now... Booo!");
    public void TakeOff() => Console.WriteLine($"Embrace yourselves! The {this.GetType()} is going to take off soon!");
    public void Track() => Console.WriteLine($"The {this.GetType()} is sending its position.");
}
class Jet : FlightEnabled, Trackable
{
    public void TakeOff() => Console.WriteLine($"Embrace yourselves! The {this.GetType()} is going to take off soon!");
    public void Fly() => Console.WriteLine($"{this.GetType()} is flying super fast!");
    public void Land() => Console.WriteLine($"The {this.GetType()} is landing now!");
    public void Track() => Console.WriteLine($"The {this.GetType()} is storing its position.");
}
class Truck : Trackable
{
    public void Track() => Console.WriteLine($"The {this.GetType()} is storing its position.");
}
class Satellite : OrbitEarth
{
    public void AchieveOrbit() => Console.WriteLine("Orbit was achieved... 🎉");
    public void TakeOff() => Console.WriteLine($"Embrace yourselves! The {this.GetType()} is going to take off soon!");
    public void Fly() => Console.WriteLine($"{this.GetType()} is flying super fast!");
    public void Land() => Console.WriteLine($"The {this.GetType()} is landing now!");
}

record Mosquito : FlightEnabled
{
    public void TakeOff() => Console.WriteLine($"The freaking {this.GetType()} is finally taking off!");
    public void Fly() => Console.WriteLine($"Pinche {this.GetType()} no para de volar sobre mi oreja.");
    public void Land() => Console.WriteLine($"The {this.GetType()} is landing on my balls now!");
}