using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiReactor;

namespace MauiReactorTestUI.Pages;

class InvoiceUiPage : Component
{
    public override VisualNode Render()
    {
        return new ContentPage
        {
            MainLayout()
        };
    }

    VisualNode MainLayout()
        => new Grid("*", "*")
        {
            // Allow top information to be scrolled
            new ScrollView
            {

                // Layout top information
                new Grid("Auto Auto Auto Auto Auto", "*")
                {
                    BusinessInfo(),

                    ClientInfo()

                }
                .RowSpacing(12)
                .GridRow(0)
                .Margin(12)
            }
        };

    VisualNode BusinessInfo()
        => new Frame
        {
            new Grid("* * * *", "* Auto *")
            {
                new Label("BUSINESS INFOs")
                    .GridRow(0)
                    .GridColumn(0)
                    .TextColor(Color.Parse("#a0a0a0")),
                new Label("NO. 102597")
                    .GridRow(1)
                    .GridColumn(0)
                    .FontAttributes(MauiControls.FontAttributes.Bold)
                    .Padding(0,0, 0, 11),
                new Label("7 Design Studio")
                    .GridRow(2)
                    .GridColumn(0)
                    .FontAttributes(MauiControls.FontAttributes.Bold),
                new Label("7luyuhang@gmail.com")
                    .GridRow(3)
                    .GridColumn(0)
                    .TextColor(Color.Parse("#a0a0a0")),

                new BoxView().GridRow(0).GridColumn(1).GridRowSpan(4).WidthRequest(1).Margin(0,0,8,0),

                new Label("Signature")
                    .GridRow(0)
                    .GridColumn(2)
                    .TextColor(Color.Parse("#a0a0a0"))
                    .VEnd(),
            },

            //new Label("PAID")
            //    .FontSize(11)
            //    .FontAttributes(MauiControls.FontAttributes.Bold)
            //    .GridRowSpan(4)
            //    .GridColumn(2)
            //    .TextColor(Color.Parse("#ffffff"))
            //    .BackgroundColor(Color.Parse("#46aa62"))
            //    .Padding(30,50,30,6)
            //    .Rotation(40)
            //    .VerticalOptions(MauiControls.LayoutOptions.Start)
            //    .HEnd()
            //    .TranslationX(54)
            //    .TranslationY(-55)
        }
        .GridRow(0);

    VisualNode ClientInfo()
        => new Frame
        {
            new Grid("*,*,*","Auto,Auto")
            {
                new Label("CLIENTS")
                    .GridRow(0)
                    .TextColor(Color.Parse("#a0a0a0")),

                new Border()
                {
                    new Image("nike.png")
                        .Aspect(Aspect.AspectFill)
                }
                .GridRow(1)
                .GridColumn(0)
                .GridRowSpan(2)
                .Margin(0,0,20,0)
                .Stroke(Colors.Transparent)
                .BackgroundColor(Colors.White)
                .StrokeThickness(2)
                .HeightRequest(50)
                .WidthRequest(50)
                .StrokeShape(new MauiReactor.Shapes.Rectangle())
            }
            .RowSpacing(10),

            new Label("Nike Product1")
                    .GridRow(1)
                    .GridColumn(1)
                    .FontAttributes(MauiControls.FontAttributes.Bold),
        }
        .GridRow(1);

}