void PrintOrder(List<OrderItem> listOfOrderItems, string nameOfReceipt)
{
    var headerTailer = new string('-', 80);
    Console.WriteLine(headerTailer);
    Console.WriteLine($"{nameOfReceipt,40}");
    Console.WriteLine(headerTailer);
    Console.WriteLine($" Qty  | Item         | Amount       | Description");
    Console.WriteLine(headerTailer);
    decimal totalPrice = 0;
    foreach (var item in listOfOrderItems)
    {
        item.PrintItem();
        totalPrice += item.FinalPrice;
    }
    Console.WriteLine(headerTailer);
    Console.WriteLine($"TOTAL: {totalPrice:C2}");
    Console.WriteLine(headerTailer);
}

var Stock = new List<ProductForSale>();
Stock.Add(new Fruit("Manzana", 5, "Manzanas de California"));
Stock.Add(new Fruit("Naranja", 4, "Naranjas de Cataluña"));
Stock.Add(new Fruit("Pera", 3, "Peras de Toluca"));
Stock.Add(new Clothes("Blusa", 449.99M, "Blusa de manga corta. Color azul marino."));
Stock.Add(new Clothes("Jeans", 899.99M, "Jeans Levi's para caballero"));
Stock.Add(new Clothes("Sudadera", 799.99M, "Sudadera para caballero naranja"));
Stock.Add(new Electronics("Laptop", 12_999.99M, "Computadora personal HP de 8 GM RAM"));
Stock.Add(new Electronics("Celular", 7_999M, "Celular Xiaomi"));

var order1 = new List<OrderItem>();
order1.Add(new OrderItem(10, Stock[0]));
order1.Add(new OrderItem(3, Stock[2]));
order1.Add(new OrderItem(1, Stock[3]));
order1.Add(new OrderItem(2, Stock[4]));
order1.Add(new OrderItem(1, Stock[6]));

// PrintOrder(order1, "ORDER 1");

var orderSuelen = new List<OrderItem>();
orderSuelen.Add(new OrderItem(6, Stock[1]));
orderSuelen.Add(new OrderItem(2, Stock[2]));
orderSuelen.Add(new OrderItem(1, Stock[6]));
orderSuelen.Add(new OrderItem(2, Stock[3]));

PrintOrder(orderSuelen, "Order para Suelen");

