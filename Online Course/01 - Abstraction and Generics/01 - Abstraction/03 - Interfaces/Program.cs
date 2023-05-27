void inFlight(FlightEnabled flier)
{
    Console.WriteLine();
    flier.TakeOff();
    flier.Fly();
    if (flier is Trackable trackable)
        trackable.Track();
    flier.Land();
    Console.WriteLine();
}

Bird bird = new Bird();
Animal animal = bird;
FlightEnabled flier = bird;
Trackable tracked = bird;

bird.Move();
// Flaps its wings...
animal.Move();
// Flaps its wings...

bird.TakeOff();
// Embrace yourselves! The Bird is going to take off soon!
flier.Land();
// The Bird is landing now... Booo!
tracked.Track();
// The Bird is sending its position.

inFlight(flier);
// Embrace yourselves! The Bird is going to take off soon!
// Bird is flying!
// The Bird is sending its position.
// The Bird is landing now... Booo!

inFlight(new Jet());
// Embrace yourselves! The Jet is going to take off soon!
// Jet is flying super fast!
// The Jet is storing its position.
// The Jet is landing now!

inFlight(new Mosquito());
// The freaking Mosquito is finally taking off!
// Pinche Mosquito no para de volar sobre mi oreja.
// The Mosquito is landing on my balls now!

// Using Interface contants.
var kmTraveled = 8000;
var milesTraveled = FlightEnabled.KM_TO_MILES * kmTraveled;

Console.WriteLine($"I traveled {kmTraveled}km (that is {milesTraveled:F2} miles in gringo...)");
// I traveled 8000km (that is 4970.97 miles in gringo...)