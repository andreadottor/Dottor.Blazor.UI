namespace Dottor.Blazor.UI.Extensions;

using Dottor.Blazor.UI.Utilities;
using Microsoft.JSInterop;
using System.Threading.Tasks;

public static class JSRuntimeHelpers
{
    public static async ValueTask<IJSObjectReference> ImportModuleAsync(this IJSRuntime jsRuntime, string scriptPath)
    {
        return await jsRuntime.InvokeAsync<IJSObjectReference>("import", $"{scriptPath}?v={VersionUtility.GetVersion()}");
    }
}
