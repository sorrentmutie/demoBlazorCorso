using LIbreriaComponentiBlazor.Interfaces;
using LIbreriaComponentiBlazor.Models;
using System.Net.Http.Json;

namespace DemoBlazorWebAssembly.Services;

public class ReqResService : IReqResService
{
    private readonly IHttpClientFactory httpClientFactory;
    private CancellationTokenSource? cancellationTokenSource;

    public ReqResService(IHttpClientFactory httpClientFactory)
    {
        this.httpClientFactory = httpClientFactory;
    }

    public void CancelRequest()
    {
        cancellationTokenSource?.Cancel();
    }

    public async Task<ReqResData?> GetData()
    {
        var httpClient = httpClientFactory.CreateClient("reqres");
        cancellationTokenSource = new CancellationTokenSource();

        var response = await httpClient.GetAsync
            ("users?delay=1", HttpCompletionOption.ResponseHeadersRead,
             cancellationTokenSource.Token);

        if (response.IsSuccessStatusCode)
        {
            return await response
                .Content.ReadFromJsonAsync<ReqResData>();
        }
        else {
            return null;
        }

    }

    public async Task<ReqResNewUserResponse?> PostNewUser(ReqResNewUser newUser)
    {
        var httpClient = httpClientFactory.CreateClient("reqres");
        var response = await httpClient.PostAsJsonAsync("users", newUser);
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<ReqResNewUserResponse>();
        }
        else
        {
            return null;
        }
    }
}
