var cities = new DataStorage<string>("Unknown City");
var years = new DataStorage<int>(0);

cities.AddItem(0, "Mexico City");
cities.AddItem(1, "Rio de Janeiro");
cities.AddItem(2, "New York");
cities.AddItem(3, "Paris");
cities.AddItem(4, "Tokyo");

Console.WriteLine(cities.GetItem(0));
Console.WriteLine(cities.GetItem(1));
Console.WriteLine(cities.GetItem(2));
Console.WriteLine(cities.GetItem(3));
Console.WriteLine(cities.GetItem(4));
Console.WriteLine(cities.GetItem(10));
// Mexico City
// Rio de Janeiro
// New York
// Paris
// Tokyo
// Unknown City

years.AddItem(0, 1949);
years.AddItem(1, 1967);
years.AddItem(2, 1970);
years.AddItem(3, 1992);
years.AddItem(4, 1993);
// 1949
// 1967
// 1970
// 1992
// 1993
// 0

Console.WriteLine(years.GetItem(0));
Console.WriteLine(years.GetItem(1));
Console.WriteLine(years.GetItem(2));
Console.WriteLine(years.GetItem(3));
Console.WriteLine(years.GetItem(4));
Console.WriteLine(years.GetItem(10));

class DataStorage<T>
{
    T defaultValue;
    T[] _data = new T[5];
    public DataStorage(T defaultValue) { this.defaultValue = defaultValue; }

    public void AddItem(int index, T item)
    {
        if (index >= 0 && index < _data.Length)
            _data[index] = item;
        else
            Console.WriteLine("Whoopsie... That index doesn't exist.");
    }
    public T GetItem(int index)
    {
        if (index >= 0 && index < _data.Length)
            return _data[index];
        else
            return defaultValue;
    }
}