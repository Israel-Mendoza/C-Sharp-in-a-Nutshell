interface Mappable
{
    void Render();
    public static Location StringToLocation(string pointOnMap)
    {
        var pointOnMapArray = pointOnMap.Split(",");
        double latitude = 0;
        double longitude = 0;
        double.TryParse(pointOnMapArray[0], out latitude);
        if (pointOnMapArray.Length > 1)
            double.TryParse(pointOnMapArray[pointOnMapArray.Length - 1], out longitude);
        return new Location(latitude, longitude);
    }
}

record Location(double Latitude, double Longitude) { }

abstract class Point : Mappable
{
    public string Name { get; init; }
    public Location Location { get; set; }

    public Point(string name, string location)
    {
        Name = name;
        Location = Mappable.StringToLocation(location);
    }
    public Point(string name, Location location)
    {
        Name = name;
        Location = location;
    }
    public abstract void Render();
}

abstract class Line : Mappable
{
    public string Name { get; init; }
    public List<Location> Locations { get; set; } = new List<Location>();
    public Line(string name, string[] locationPoints)
    {
        Name = name;
        foreach (string location in locationPoints)
            Locations.Add(Mappable.StringToLocation(location));
    }
    public Line(string name, Location[] locationPoints)
    {
        Name = name;
        foreach (Location location in locationPoints)
            Locations.Add(location);
    }
    public abstract void Render();
}

class Park : Point
{
    public Park(string name, string location) : base(name, location) { }
    public Park(string name, Location location) : base(name, location) { }

    public override void Render()
    {
        Console.WriteLine($"Name: {Name}\n\t{Location}");
    }
}

class River : Line
{
    public River(string name, string[] locationPoints) : base(name, locationPoints) { }
    public River(string name, Location[] locationPoints) : base(name, locationPoints) { }
    public override void Render()
    {
        Console.WriteLine($"Name: {Name}");
        foreach (var location in Locations)
            Console.WriteLine($"\t{location}");
    }
}

class Layer<T> where T : Mappable
{
    private List<T> elements = new List<T>();
    public void AddElement(T newElement) => elements.Add(newElement);
    public void AddElements(List<T> newElements)
    {
        foreach (T element in newElements)
            elements.Add(element);
    }
    public void RenderLayer()
    {
        Console.WriteLine($"Renderting a list of '{elements.First().GetType()}s'.");
        foreach (var element in elements)
            element.Render();
        Console.WriteLine();
    }
}