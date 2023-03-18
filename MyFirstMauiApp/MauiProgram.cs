using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MyFirstMauiApp.Pages;
using MyFirstMauiApp.ViewModels;

namespace MyFirstMauiApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddTransient<MainPage>();

		builder.Services.AddTransient<ServiceExteriorViewModel>();
		builder.Services.AddTransient<ServiceExterior>();


		return builder.Build();
	}
}
