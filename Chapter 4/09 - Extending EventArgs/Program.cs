var order = new Order();

order.OnCreated += Email.Send;
order.OnCreated += SMS.Send;

order.Create("john@test.com", "(408)-111-2222");
// Order created
// Send an email to john@test.com as requested by Order.
// Send an SMS to (408)-111-2222 as requested by Order.

// Extending the EventArgs class by adding two new properties:
class OrderEventArgs : EventArgs
{
    public string? Email { get; set; }
    public string? Phone { get; set; }
}

class Order
{
    // Creating a generic event instance called OnCreated:
    public event EventHandler<OrderEventArgs>? OnCreated;

    public void Create(string email, string phone)
    {
        Console.WriteLine("Order created");

        // Raising the event if this one is not null.
        // The EventArgs is a new instance of the new subclass of EventArgs:
        OnCreated?.Invoke(this, new OrderEventArgs { Email = email, Phone = phone });

    }
}

class Email
{
    public static void Send(object sender, OrderEventArgs e) => Console.WriteLine($"Send an email to {e.Email} as requested by {sender}.");
}

class SMS
{
    public static void Send(object sender, OrderEventArgs e) => Console.WriteLine($"Send an SMS to {e.Phone} as requested by {sender}.");
}
