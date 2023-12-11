using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiApp1.Data;
using Syncfusion.Blazor;

namespace MauiApp1;

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
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddSyncfusionBlazor();

        //Register Syncfusion license
        //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjY4NjQxMkAzMjMyMmUzMDJlMzBoZHJLM2lpVDZjdDlZV3gxSGNRZm5TYzJhOGpsakI3NHRtZlZ6Rmg4QXZBPQ==");
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjc5OTY2MUAzMjMzMmUzMDJlMzBIcllJQWJEYWVvWVRXY0ZWYUN5RDFXZDVQYmt4RjY4YnFGdkJBeTlZQ2Z3PQ==");



        return builder.Build();
	}
}
