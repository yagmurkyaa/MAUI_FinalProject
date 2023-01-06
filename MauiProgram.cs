using _180201028_yagmurkaya_cproject.DataTransaction;

namespace _180201028_yagmurkaya_cproject;

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

        string dbtrans = Path.Combine(FileSystem.AppDataDirectory, "Movie.db");
        builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<DBTrans>(s, dbtrans));
        return builder.Build();
    }
}
