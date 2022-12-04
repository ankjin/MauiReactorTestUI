using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiReactor;

namespace MauiReactorTestUI.Pages;

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
                    new SKLottieView().Source("dotnetbot.json")
                        .RepeatCount(1)
                        .HeightRequest(20)
                        .WidthRequest(20)
                        .HCenter()
                }
                .VCenter()
                .Spacing(25)
                .Padding(30, 0)
            }
        };
    }
}
