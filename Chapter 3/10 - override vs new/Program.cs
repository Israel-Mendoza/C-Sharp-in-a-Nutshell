/*
    When overriding a method in a subclass, whether we use the keywords 
    "override", "new" or no keyword whatsoever, the method will works as 
    specified by the overriding class, provided the method is called as
    part of an instance instantiated from the overriding subclass.
*/


var b = new BaseClass(); // Base class with the original method.
var f = new Forgetter(); // Subclass that "forgot" to override the method.
var o = new Overrider(); // Subclass that explicitly overrides the method.
var h = new Hider(); // Subclass that hides the method.

b.SayHello();
// BaseClass says 'Hello!'.
f.SayHello();
// Forgetter says 'Hello!'.
o.SayHello();
// Overrider says 'Hello!'.
h.SayHello();
// Hider says 'Hello!'.

/*
    However, if the method is called as if it was part of an instance
    created by the base clase, only the methods marked as "override"
    will still run the code defined in the "override" method.
    If we use "new" or no keyword, the method will run the code defined
    in the original "virtual" method in the base class.
*/

// Method that will call the "overriden" SayHello method on BaseClass instances.
void MakeItSayHello(BaseClass b) => b.SayHello();

// Upcasting to BaseClass.
BaseClass bf = f;
BaseClass bo = o;
BaseClass bh = h;


// Notice how only the "overriden" method will result in the "overriden" code:
b.SayHello();
// BaseClass says 'Hello!'.
bf.SayHello();
// BaseClass says 'Hello!'.
bo.SayHello();
// Overrider says 'Hello!'.
bh.SayHello();
// BaseClass says 'Hello!'.

// Notice how only the "overriden" method will result in the "overriden" code:
MakeItSayHello(b);
// BaseClass says 'Hello!'.
MakeItSayHello(f);
// BaseClass says 'Hello!'.
MakeItSayHello(o);
// Overrider says 'Hello!'.
MakeItSayHello(h);
// BaseClass says 'Hello!'.

// Base class defining a virtual method.
class BaseClass
{
    public virtual void SayHello() => Console.WriteLine("BaseClass says 'Hello!'.");
}

// Let's forget to override or add the "new" keyword to the method that overrides "SayHello".
class Forgetter : BaseClass
{
    public void SayHello() => Console.WriteLine("Forgetter says 'Hello!'.");
}

// Let's actually override the "SayHello".
class Overrider : BaseClass
{
    public override void SayHello() => Console.WriteLine("Overrider says 'Hello!'.");
}

// Let's tell the compiler that we actually want to hide the "SayHello" method:

class Hider : BaseClass
{
    public new void SayHello() => Console.WriteLine("Hider says 'Hello!'.");
}

