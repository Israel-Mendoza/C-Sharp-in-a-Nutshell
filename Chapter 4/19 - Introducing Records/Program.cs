using static System.Console;

/*
    Records works exactly the same as a class (they are also reference values).
    The difference is that:
        1. When tested for equality, an instance of a class will be different to any other
        since the == operator is comparing the actual reference to the object. 
        2. A record will test True for equality if two different instances of the record
        have exactly the same properties with the same values.
        3. A record is used preferably with unmutable data.
*/

//////////////////WORKING WITH A CLASS//////////////////

var pc1 = new ProductClass(1, "Tomato", 1.99M);
var pc2 = pc1;

WriteLine(pc1 == pc2); // True (they're the same object).

pc2 = new ProductClass(1, "Tomato", 1.99M); // Creating a new object but with the same information and pc1.

WriteLine(pc1 == pc2); // False (they're not the same object).

//////////////////WORKING WITH A RECORD//////////////////

var pr1 = new ProductRecord(1, "Tomato", 1.99M);
var pr2 = pr1;

WriteLine(pr1 == pr2); // True (they're the same object).

pr2.Description = "A tasty vegetable.";

WriteLine(pr1 == pr2); // True (they're the same object).

WriteLine(pr1);
// ProductRecord { ID = 1, Name = Tomato, Price = 1.99, Description = A tasty vegetable. }
WriteLine(pr2);
// ProductRecord { ID = 1, Name = Tomato, Price = 1.99, Description = A tasty vegetable. }

pr2 = new ProductRecord(1, "Tomato", 1.99M); // Creating a new record for pr2 with exactly the same information as pr1.
pr2.Description = "A tasty vegetable.";

WriteLine(pr1 == pr2); // True (the information contained is exactly the same)

WriteLine(pr1);
// ProductRecord { ID = 1, Name = Tomato, Price = 1.99, Description = A tasty vegetable. }
WriteLine(pr2);
// ProductRecord { ID = 1, Name = Tomato, Price = 1.99, Description = A tasty vegetable. }

// Let's edit one of the records just slightly:
pr1.Price = 1.98M;

WriteLine(pr1 == pr2); // False (the information contained is slightly different)

WriteLine(pr1);
// ProductRecord { ID = 1, Name = Tomato, Price = 1.98, Description = A tasty vegetable. }
WriteLine(pr2);
// ProductRecord { ID = 1, Name = Tomato, Price = 1.99, Description = A tasty vegetable. }

class ProductClass
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public ProductClass(int ID, string Name, decimal Price)
    {
        this.ID = ID;
        this.Name = Name;
        this.Price = Price;
    }
}

record ProductRecord
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public ProductRecord(int ID, string Name, decimal Price)
    {
        this.ID = ID;
        this.Name = Name;
        this.Price = Price;
    }
}