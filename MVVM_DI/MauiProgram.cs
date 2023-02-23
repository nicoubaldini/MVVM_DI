using Microsoft.Extensions.Logging;
using MVVM_DI.Interfaces;
using MVVM_DI.Services;
using MVVM_DI.ViewModels;
using MVVM_DI.Views;

namespace MVVM_DI;

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
		builder.Services.AddScoped<FileListView>();
		builder.Services.AddScoped<FileListViewModel>();
        builder.Services.AddScoped<FileDetailView>();
        builder.Services.AddScoped<FileDetailViewModel>();
        builder.Services.AddSingleton<INavigationService, NavigationService>();
        builder.Services.AddSingleton<IFileService, FileService>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
