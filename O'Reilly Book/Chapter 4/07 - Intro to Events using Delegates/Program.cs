// Creating the object that will contain the Event handler.
var order = new Order();

// Adding subscribers to the event:
order.OnCreated += Email.Send; // Adding a subscriber to the event.
order.OnCreated += SMS.Send; // Adding another subscriber to the event.

order.Created(); // Raising the event.
// Order created
// Sending an email!
// Sending an SMS!


///////////////////CREATING THE DELEGATE, THE EVENT, AND THE SUBSCRIBERS///////////////////


// Delegate: no arguments and no return value.
// Publisher and Subscribers must match the delegate.
delegate void OrderEventHandler();

class Order
{
    public event OrderEventHandler? OnCreated; // Creating the event, which type is "OrderEventHandler".
    public void Created()
    {
        Console.WriteLine("Order created"); // Method with the delegate's signature.
        OnCreated?.Invoke(); // Raising the event in case this one is not null.
    }
}

class Email
{
    public static void Send() => Console.WriteLine("Sending an email!");
}

class SMS
{
    public static void Send() => Console.WriteLine("Sending an SMS!");
}