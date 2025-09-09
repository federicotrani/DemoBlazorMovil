using Microsoft.Extensions.Logging;

namespace DemoBlazorMovil
{
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

            // Inyección de dependencias para HttpClient
            builder.Services.AddSingleton<HttpClient>(sp =>
            {
                var navigationManager = sp.GetRequiredService<Microsoft.AspNetCore.Components.NavigationManager>();
                return new HttpClient
                {
                    //BaseAddress = new Uri(navigationManager.BaseUri)
                    BaseAddress = new Uri("https://localhost:7188")
                };
            });

            builder.Services.AddScoped<Services.ProductoService>();
            builder.Services.AddScoped<Services.AlertaService>();

            
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

        

            return builder.Build();
        }
    }
}
