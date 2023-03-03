namespace Dottor.Blazor.UI.Services;

using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

public class ModalService : IModalService, IAsyncDisposable
{
    private readonly IJSRuntime          _jsRuntime;
    private IJSInProcessObjectReference? _modalObjectReference;

    public event EventHandler<ModalShowEventArgs> OnShowCommand;
    public event EventHandler<ModalHideEventArgs> OnHideCommand;

    public ModalService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public void Show(string id)
    {
        OnShowCommand?.Invoke(this, new ModalShowEventArgs(id));
    }
    public ValueTask ShowAsync(string id)
    {
        OnShowCommand?.Invoke(this, new ModalShowEventArgs(id));
        return ValueTask.CompletedTask;
    }

    public void Hide(string id)
    {
        OnHideCommand?.Invoke(this, new ModalHideEventArgs(id));
    }

    public ValueTask HideAsync(string id)
    {
        OnHideCommand?.Invoke(this, new ModalHideEventArgs(id));
        return ValueTask.CompletedTask;
    }

    public async ValueTask DisposeAsync()
    {
        if (_modalObjectReference is not null)
            await _modalObjectReference.DisposeAsync();
    }
}