using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiReactor;
using SkiaSharp.Extended.UI.Controls;

namespace MauiReactorTestUI.Pages;


[Scaffold(typeof(SkiaSharp.Extended.UI.Controls.SKSurfaceView))]
partial class SKSurfaceView { }

[Scaffold(typeof(SkiaSharp.Extended.UI.Controls.SKAnimatedSurfaceView))]
partial class SKAnimatedSurfaceView { }

[Scaffold(typeof(SkiaSharp.Extended.UI.Controls.SKLottieView))]
partial class SKLottieView { }

class LottieAnimationPage : Component
{
    public override VisualNode Render()
    {
        return new ContentPage
        {
            new ScrollView
            {
                new VerticalStackLayout
                {
                    new SKLottieView()
                        .Source(new SKFileLottieImageSource
                        {
                            File = "dotnetbot.json",
                        })
                        .RepeatCount(-1)
                        .HeightRequest(100)
                        .WidthRequest(100)
                        .HCenter()
                }
                .VCenter()
                .Spacing(25)
                .Padding(30, 0)
            }
        };
    }

}
