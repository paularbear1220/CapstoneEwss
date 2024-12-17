using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using SkiaSharp.Views.Maui.Controls;
using OxyPlot.SkiaSharp;
using ewssApp1;
using SkiaSharp.Views.Maui.Controls.Hosting;
using Android.Media.Effect;
using OxyPlot.Maui.Skia.Effects;
using SkiaSharp.Views;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
               .UseSkiaSharp()  // Register SkiaSharp
               .ConfigureFonts(fonts =>
               {
                   fonts.AddFont("WorldMadlyTree2-eZxW6.otf", "LeafyFont");
               });
        return builder.Build();
    }
}
