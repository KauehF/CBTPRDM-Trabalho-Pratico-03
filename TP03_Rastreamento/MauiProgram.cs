//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using Microsoft.Extensions.Logging;
using TP03_Rastreamento.Services;
using TP03_Rastreamento.ViewModels;
using TP03_Rastreamento.Views;

namespace TP03_Rastreamento
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Services

            builder.Services.AddSingleton<
                IRastreamentoService,
                RastreamentoServiceFake>();

            builder.Services.AddSingleton<
                INavigationService,
                NavigationService>();

            // ViewModels

            builder.Services.AddSingleton<RastreamentoViewModel>();

            // Views

            builder.Services.AddTransient<BuscaPage>();
            builder.Services.AddTransient<ResultadoPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}