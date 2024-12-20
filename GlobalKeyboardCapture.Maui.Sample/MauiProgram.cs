﻿using GlobalKeyboardCapture.Maui.Configuration;
using GlobalKeyboardCapture.MauiSample;
using Microsoft.Extensions.Logging;

namespace GlobalKeyboardCapture.Maui.Sample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseKeyboardHandling()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("FontAwesome6Brands-Regular-400.otf", "FABrands");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<MainPage>();

            // Adiciona o serviço de teclado com configurações personalizadas
            builder.Services.AddKeyboardHandling(options =>
            {
                options.BarcodeTimeout = 150;
                options.MinBarcodeLength = 5;
            });

            return builder.Build();
        }
    }
}
