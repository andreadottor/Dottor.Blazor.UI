namespace Dottor.Blazor.UI.Services;

using System;
using System.Threading.Tasks;

public record ModalShowEventArgs(string ModalId);
public record ModalHideEventArgs(string ModalId);

public interface IModalService
{
    event EventHandler<ModalShowEventArgs> OnShowCommand;
    event EventHandler<ModalHideEventArgs> OnHideCommand;

    ValueTask ShowAsync(string id);
    ValueTask HideAsync(string id);

    void Show(string id);
    void Hide(string id);
}
