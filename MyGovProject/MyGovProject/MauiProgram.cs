using Microsoft.Extensions.Logging;
using MyGovProject.ViewModels;
using MyGovProject.Views;

namespace MyGovProject;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.Services.AddTransient<OnboardingView>();
        builder.Services.AddTransient<JourneyView>();
        builder.Services.AddTransient<OnboardingViewModel>();
        builder.Services.AddTransient<JourneyViewModel>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
