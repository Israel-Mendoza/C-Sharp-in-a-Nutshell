
var order = new Order();

// Adding subscribers to the event:
order.OnCreated += Email.Send;
order.OnCreated += SMS.Send;

// Raising the event.
order.Create();

//////////////////////////////////////////////////////////////////////

// We will use C#'s standard EventHandler delegate.
// It received the reference to the object that raises the event
// and possible arguments, which normally will be empty.
public delegate void EventHandler(object sender, EventArgs e);

class Order
{
    public event EventHandler? OnCreated;

    public void Create()
    {
        Console.WriteLine("Order created!");
        // If the Event is not null, it will be invoked
        // passing the this reference as the object, and 
        // the special field of EventArgs called "Empty".
        OnCreated?.Invoke(this, EventArgs.Empty);
    }
}


class Email
{
    // Methods that will be used as subscribers. Note how they still comply with the delegate's signature.
    // The publisher will be in charged of providing the arguments as the event raises. 
    public static void Send(object sender, EventArgs e) => Console.WriteLine($"Sending an email, as requested by {sender}!");
}

class SMS
{
    public static void Send(object sender, EventArgs e) => Console.WriteLine($"Sending an SMS, as requested by {sender}!");
}