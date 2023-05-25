var p1 = new Person("");
var p2 = new Person("Israel");
p1.Introduce();
// Hello, my name is Unknown and I'm 18 years old.
p2.Introduce();
// Hello, my name is Israel and I'm 18 years old.

class Person
{
    string? name;
    public Person(string newName)
    {
        this.Name = newName;
    }
    // Read and write property:
    public string? Name
    {
        get { return name; }
        init // This is normally "set", but "init" allows us to use it just once, during the initialization of the object. 
        { 
            if (value?.Trim().Length == 0) 
                name = "Unknown";
            else
                name = value;
        }
    }
    // An automatic property. Additionally, we initialize it with a default value:
    public int Age { get; set; } = 18;
    public bool ChangeName(string newName)
    {
        
        if (newName.Trim().Length == 0)
        {
            this.name = "Unknown";
            return false;
        }
        else
        {
            this.name = newName;
            return true;
        }
                
    }
    public void Introduce() 
    {
        Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old.");
    }
}

class Square
{
    double side;
    public Square(double side)
    {
        this.side = side;
    }
    // Read and Write property:
    public double Side 
    { 
        get =>  side; 
        set => this.side = Math.Abs(value);
    }
    // Read-only property:
    public double Area 
    {
        get => Math.Pow(this.side, 2);
    }
}