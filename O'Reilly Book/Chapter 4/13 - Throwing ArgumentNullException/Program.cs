void PrintString(string? aMessage)
{
    if (aMessage == null)
        throw new ArgumentNullException(nameof(aMessage));
    else
        Console.WriteLine(aMessage);
}

void PrintString2(string? aMessage)
{
    // Being so common, there's a better way to throw the error:
    ArgumentNullException.ThrowIfNull(aMessage);
    Console.WriteLine(aMessage);
}

string? myMessage = null;

try
{
    PrintString(myMessage);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex);
}
// System.ArgumentNullException: Value cannot be null. (Parameter 'aMessage')
try
{
    PrintString2(myMessage);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex);
}
// System.ArgumentNullException: Value cannot be null. (Parameter 'aMessage')