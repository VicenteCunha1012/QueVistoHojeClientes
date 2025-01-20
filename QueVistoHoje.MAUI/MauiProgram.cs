using Microsoft.Extensions.Logging;
using QueVistoHoje.RCL.Data;

namespace QueVistoHoje.MAUI {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddHttpClient();
            builder.Services.AddSingleton<UserService>();
<<<<<<< HEAD
            builder.Services.AddSingleton<APIService>();
=======
>>>>>>> 817da96e6c7472d81c14db231778c170d33ecb80

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
