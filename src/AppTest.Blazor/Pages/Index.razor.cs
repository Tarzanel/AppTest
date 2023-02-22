using AppTest.Alive;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace AppTest.Blazor.Pages;

public partial class Index
{
    [Inject]
    IAliveAppService AliveService { get; set; }

    private async Task CallAlive()
    {
        var response = await AliveService.CallAlive();
        Console.WriteLine(response);
    }
}
