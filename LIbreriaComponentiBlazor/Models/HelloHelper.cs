using Microsoft.JSInterop;

namespace LIbreriaComponentiBlazor.Models;

public  class HelloHelper
{
    public HelloHelper(string name)
    {
        Name = name;
    }
    public string Name { get; set; }

    [JSInvokable]
    public string SayHello()
    {
        return $"Ciao {Name}!";
    }
}
