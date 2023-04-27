// When we catch a variable from inside a loop, 
// the captured data will refer to the same end value.

Action[] myActions = new Action[5];

for (var i = 0; i < 5; i++)
{
    myActions[i] = () => Console.WriteLine(i);
}

foreach (var action in myActions)
{
    action();
}
// 5
// 5
// 5
// 5
// 5

// To avoid this problem, we must "create" a new i variable
// in every iteration before assign it to the closure:
for (var i = 0; i < 5; i++)
{
    int localIValue = i;
    myActions[i] = () => Console.WriteLine(localIValue);
}

foreach (var action in myActions)
{
    action();
}
// 0
// 1
// 2
// 3
// 4