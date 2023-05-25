var p1 = new ProductOne() { ID = 123, Name = "Tomato", Price = 1.99M };
var p2 = new ProductTwo(123, "Tomate", 1.99M);

/*
// Trying to set values to any of the fields will result in an error:
p1.ID = 321;
// error CS8852: Init-only property or indexer 'ProductOne.ID' can only 
// be assigned in an object initializer, or on 'this' or 'base' in an instance 
//constructor or an 'init' accessor.
*/
/*
p2.Description = "A tasty vegetable";
// error CS8852: Init-only property or indexer 'ProductTwo.Description' 
// can only be assigned in an object initializer, or on 'this' or 'base' 
// in an instance constructor or an 'init' accessor.
*/

// Creating a new instance of ProductOne, using most of the 
// information from p1 but setting a different Description: 
var p3 = p1 with { Description = "A tasty vegetable... Yummy!!!" };

///////////////////CREATING RECORDS///////////////////

record ProductOne
{
    // All of our properties will be read-only after being initialized:
    public int ID { get; init; }
    // required means we won't be able to create an instance of the record if this property is not set:
    public required string Name { get; init; }
    public decimal Price { get; init; }
    public string? Description { get; init; }
}

record ProductTwo(int ID,
                    string Name,
                    decimal Price,
                    string? Description = null);