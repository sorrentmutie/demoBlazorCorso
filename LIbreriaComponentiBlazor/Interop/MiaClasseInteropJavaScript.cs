using Microsoft.JSInterop;

namespace LIbreriaComponentiBlazor.Interop;

public class MiaClasseInteropJavaScript
{
    private readonly IJSRuntime jSRuntime;
    private readonly Lazy<Task<IJSObjectReference>> moduleTask;

    public MiaClasseInteropJavaScript(IJSRuntime jSRuntime)
    {
        this.jSRuntime = jSRuntime;
        moduleTask = new(() => jSRuntime.InvokeAsync<IJSObjectReference>
            ("import", "./_content/LIbreriaComponentiBlazor/js/mioPrimoFile.js")
            .AsTask ());
    }

    public async ValueTask<string> MiaPrimaFunzione()
    {
        var module = await moduleTask.Value;
        return await module.InvokeAsync<string>("miaPrimaFunzione");
    }

    public async ValueTask<int> MiaSecondaFunzione(string nome)
    {
        var module = await moduleTask.Value;
        return await module.InvokeAsync<int>("miaSecondaFunzione", nome);
    }

}
