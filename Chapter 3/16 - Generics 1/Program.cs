// Instantiating DataStore with T being string and int.
var strStore = new DataStore<string>("Salut, les gars!");
var intStore = new DataStore<int>(1992);

// Instantiating KeyValuePair with TKey being an int and TValue, a string.
var kvp1 = new KeyValuePair<int, string>(1, "Uno");

/////////////////

Console.WriteLine(strStore.Data.GetType().Name);
// String
Console.WriteLine(intStore.Data.GetType().Name);
// Int32
Console.WriteLine(kvp1.Key.GetType().Name);
// Int32
Console.WriteLine(kvp1.Value.GetType().Name);
// String

/////////////////

// Trying to change the type will result in a compile error:
/*
strStore.Data = 1;
Cannot implicitly convert type 'int' to 'string'
*/

/*
kvp1.Value = true;
Cannot implicitly convert type 'bool' to 'string'
*/

class DataStore<T> // The type will will be a placeholder for future class implementation.
{
    public T Data;
    public DataStore(T Data) { this.Data = Data; }
}

class KeyValuePair<TKey, TValue> // Two different types can be used, as long as they're not mixed up.
{
    public TKey Key;
    public TValue Value;
    public KeyValuePair(TKey Key, TValue Value)
    {
        this.Key = Key;
        this.Value = Value;
    }
}