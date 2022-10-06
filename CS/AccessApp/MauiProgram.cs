using DevExpress.Maui;
using DevExpress.Maui.Editors;

namespace AccessApp;

public static class MauiProgram {
	public static MauiApp CreateMauiApp() {
		var builder = MauiApp.CreateBuilder();
		builder
		.UseMauiApp<App>()
        	.UseDevExpress()
         	.ConfigureFonts(fonts =>
		{
			fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
		});
	return builder.Build();
	}
}
