namespace Dottor.Blazor.UI.Services;

using System;
using System.Threading.Tasks;

public record MessageBoxShowEventArgs(string Title, string Text, MessageBoxType MessageBoxType, Func<bool, Task> ReturnCallback);

public interface IMessageBoxService
{
    event EventHandler<MessageBoxShowEventArgs>? MessageBoxShow;
    Task ShowAlertAsync(string title, string text);
    Task<bool> ShowConfirmAsync(string title, string text);
}

public enum MessageBoxType
{
    Alert,
    Confirm
}
