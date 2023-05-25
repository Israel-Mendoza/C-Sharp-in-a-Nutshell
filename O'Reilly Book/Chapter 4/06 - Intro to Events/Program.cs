/*
    Suppose we want to send our clients an email 
    and an SMS whenever we create a new order.
*/



// Creating an order object.
var order = new Order();

// Calling the Create() method, which calls Email.Send() and SMS.Send():
order.Create();
// Order created!
// Email is being sent!
// SMS is being sent!


class Order // Publisher
{
    public void Create()
    {
        /*
            We can subscribe other class' methods to 
            the Create method from a given order instance.
        */
        Console.WriteLine("Order created!");
        Email.Send(); // Subscribing Email.Send() to the order.Create method.
        SMS.Send(); // Subscribing Email.Send() to the order.Create method.
    }
}

class Email // Subscriber
{
    public static void Send() => Console.WriteLine("Email is being sent!");
}

class SMS // Subscriber
{
    public static void Send() => Console.WriteLine("SMS is being sent!");
}