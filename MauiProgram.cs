﻿using AutoSchoolApp.Pages;
using AutoSchoolApp.ViewModels;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace AutoSchoolApp
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
                })
                .UseMauiCommunityToolkit();

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<DrivingSignPage>();
            builder.Services.AddTransient<ForgotPasswordPage>();
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<OnboardingPage>();
            builder.Services.AddTransient<PrepQuestionsPage>();
            builder.Services.AddTransient<PrepTicketsPage>();
            builder.Services.AddTransient<SignUpPage>();
            builder.Services.AddTransient<SignInPage>();

            builder.Services.AddSingleton<SignUpViewModel>();
            builder.Services.AddSingleton<SignInViewModel>();
            builder.Services.AddSingleton<DrivingSignViewModel>();
            builder.Services.AddSingleton<ForgotPasswordViewModel>();

            return builder.Build();
        }
    }
}
