using Microsoft.JSInterop;

namespace LIbreriaComponentiBlazor.Models;

public class HelloInterop : IDisposable
{
    private readonly IJSRuntime jSRuntime;
    private DotNetObjectReference<HelloHelper>? _objectReference;

    public HelloInterop(IJSRuntime jSRuntime)
    {
        this.jSRuntime = jSRuntime;
    }

    public ValueTask CallHelloHelperSayHello(string name)
    {
        _objectReference = DotNetObjectReference.Create(new HelloHelper(name));
        return jSRuntime.InvokeVoidAsync("sayHello", _objectReference);
    }

    public void Dispose()
    {
        _objectReference?.Dispose();
    }
}
