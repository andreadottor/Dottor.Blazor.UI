namespace Dottor.Blazor.UI;

using Dottor.Blazor.UI.Services;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddDottorUI(this IServiceCollection services)
    {
        services.AddScoped<IModalService, ModalService>();
        services.AddScoped<IMessageBoxService, MessageBoxService>();

        return services;
    }
}
