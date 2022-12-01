using MauiReactor;
using MauiReactor.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiReactorTestUI.Pages;

class InvoiceUiPage : Component
{
    public override VisualNode Render()
    {
        return new ContentPage("Home")
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

                    ClientInfo(),

                    ItemsInfo(),

                    new Label("PAID")
                    .FontSize(11)
                    .FontAttributes(MauiControls.FontAttributes.Bold)
                    .GridRow(0)
                    .GridRowSpan(5)
                    .GridColumn(0)
                    .TextColor(Color.Parse("#ffffff"))
                    .BackgroundColor(Color.Parse("#46aa62"))
                    .Margin(0,0,0,0)
                    .Padding(30,55,20,2)
                    .Rotation(40)
                    .VerticalOptions(MauiControls.LayoutOptions.Start)
                    .HEnd()
                    .TranslationX(32)
                    .TranslationY(-44),

                }
                .RowSpacing(12)
                .GridRow(0)
                .Margin(12)

            },

            BottomBar()
        }
        .BackgroundColor(Colors.Gainsboro);

    VisualNode BusinessInfo()
        => new Frame
        {

            new Grid("Auto Auto Auto Auto", "* Auto *")
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

                new Label("Signatures")
                    .GridRow(0)
                    .GridColumn(2)
                    .TextColor(Color.Parse("#a0a0a0"))
                    .VEnd(),

            }.RowSpacing(8),

        }
        .Margin(0)
        .BackgroundColor(Colors.White)
        .GridRow(0);


    VisualNode ClientInfo()
        => new Frame
        {
            new Grid("* * *","Auto * Auto")
            {
                new Label("CLIENTS")
                    .GridRow(0)
                    .GridColumn(0)
                    .TextColor(Color.Parse("#a0a0a0")),

                new Label("...")
                    .GridRow(0)
                    .GridColumn(2)
                    .FontSize(20)
                    .FontAttributes(MauiControls.FontAttributes.Bold)
                    .Margin(0,-8,0,0)
                    .TextColor(Color.Parse("#a0a0a0")),

                new Border()
                {
                    new Image("niken.png")
                        .Aspect(Aspect.AspectFill)
                }
                .GridRow(1)
                .GridColumn(0)
                .GridRowSpan(2)
                .Margin(0,0,20,0)
                .Padding(4)
                .Stroke(Colors.Transparent)
                .BackgroundColor(Colors.White)
                .StrokeThickness(2)
                .HeightRequest(50)
                .WidthRequest(50),
                //.StrokeShape(MauiControls.Shapes.RoundRectangle()),

                new Label("Nike Product")
                        .GridRow(1)
                        .GridColumn(1)
                        .FontAttributes(MauiControls.FontAttributes.Bold),
                new Label("develop-project@gmail.com")
                        .GridRow(2)
                        .GridColumn(1)
                        .TextColor(Color.Parse("#a0a0a0")),
                
                new Label("Edit")
                        .GridRow(1)
                        .GridColumn(2)
                        .GridRowSpan(2)
                        .VCenter()
                        .FontAttributes(MauiControls.FontAttributes.Bold),
            }
            .RowSpacing(10),
        }
        .BackgroundColor(Colors.Beige)
        .GridRow(1);



    VisualNode ItemsInfo()
        => new Frame
        {
            new VStack(spacing:10)
            {
                new Grid("* * *","Auto * Auto")
                {
                    new Label("ITEMS")
                        .GridRow(0)
                        .GridColumn(0)
                        .TextColor(Color.Parse("#a0a0a0")),

                    new Label("PRICE")
                        .GridRow(0)
                        .GridColumn(2)
                        .FontAttributes(MauiControls.FontAttributes.Bold)
                        .TextColor(Color.Parse("#a0a0a0"))
                        .HEnd(),

                    new Border()
                    {
                        new Label("01")
                        .GridRow(0)
                        .GridColumn(2)
                        .FontAttributes(MauiControls.FontAttributes.Bold)
                        .TextColor(Color.Parse("#a0a0a0"))
                        .HCenter()
                        .VCenter(),
                    }
                    .GridRow(1)
                    .GridColumn(0)
                    .GridRowSpan(2)
                    .Margin(0,0,20,0)
                    .Padding(4)
                    .Stroke(Colors.Transparent)
                    .BackgroundColor(Colors.White)
                    .StrokeThickness(2)
                    .HeightRequest(34)
                    .WidthRequest(34),
                    //.StrokeShape(MauiControls.Shapes.RoundRectangle()),

                    new Label("Dashboard Design")
                        .GridRow(1)
                        .GridColumn(1)
                        .FontAttributes(MauiControls.FontAttributes.Bold),
                    new Label("Quantity: 3 pages")
                        .GridRow(2)
                        .GridColumn(1)
                        .TextColor(Color.Parse("#a0a0a0")),

                    new Label("$1,025.27")
                        .GridRow(1)
                        .GridColumn(2)
                        .GridRowSpan(2)
                        .VCenter()
                        .FontAttributes(MauiControls.FontAttributes.Bold),
                }
                .RowSpacing(10),

                new BoxView()
                    .Color(Color.Parse("#a0a0a0"))
                    .Margin(30,0)
                    .HeightRequest(1)
                    .HFill(),

                new Grid("* * *","Auto * Auto")
                {
                    //new Label("ITEMS")
                    //    .GridRow(0)
                    //    .GridColumn(0)
                    //    .TextColor(Color.Parse("#a0a0a0")),

                    //new Label("PRICE")
                    //    .GridRow(0)
                    //    .GridColumn(2)
                    //    .FontAttributes(MauiControls.FontAttributes.Bold)
                    //    .TextColor(Color.Parse("#a0a0a0"))
                    //    .HEnd(),

                    new Border()
                    {
                        new Label("02")
                        .GridRow(0)
                        .GridColumn(2)
                        .FontAttributes(MauiControls.FontAttributes.Bold)
                        .TextColor(Color.Parse("#a0a0a0"))
                        .HCenter()
                        .VCenter(),
                    }
                    .GridRow(1)
                    .GridColumn(0)
                    .GridRowSpan(2)
                    .Margin(0,0,20,0)
                    .Padding(4)
                    .Stroke(Colors.Transparent)
                    .BackgroundColor(Colors.White)
                    .StrokeThickness(2)
                    .HeightRequest(34)
                    .WidthRequest(34),
                    //.StrokeShape(MauiControls.Shapes.RoundRectangle()),

                    new Label("Technial Support")
                        .GridRow(1)
                        .GridColumn(1)
                        .Margin(0,-10,0,0)
                        .FontAttributes(MauiControls.FontAttributes.Bold),
                    new Label("Quantity: 1 year")
                        .GridRow(2)
                        .GridColumn(1)
                        .Margin(0,-6,0,0)
                        .TextColor(Color.Parse("#a0a0a0")),

                    new Label("$1,225.00")
                        .GridRow(1)
                        .GridColumn(2)
                        .GridRowSpan(2)
                        .VCenter()
                        .FontAttributes(MauiControls.FontAttributes.Bold),
                }
                .RowSpacing(10),

                new Grid("Auto Auto Auto","Auto * Auto")
                {
                    new BoxView()
                        .GridRow(0)
                        .GridColumnSpan(2)
                        .Color(Color.Parse("#a0a0a0"))
                        .Margin(30,30,30,26)
                        .HeightRequest(1)
                        .HFill(),

                    new Button("Add Item")
                        .GridRow(0)
                        .GridColumn(1)
                        .CornerRadius(40)
                        .WidthRequest(120)
                        .HeightRequest(38)
                },

                new Grid("Auto Auto Auto Auto Auto","* *")
                {
                    new Label("Subtotal")
                        .GridRow(0)
                        .GridColumn(0),
                    new Label("$2,250.27")
                        .GridRow(0)
                        .GridColumn(1)
                        .HEnd(),
                    
                    new Label("Discount")
                        .GridRow(1)
                        .GridColumn(0),
                    new Label("$ -651.50")
                        .GridRow(1)
                        .GridColumn(1)
                        .HEnd(),
                    
                    new Label("Tax")
                        .GridRow(2)
                        .GridColumn(0),

                    new Label("$ +190.00")
                        .GridRow(2)
                        .GridColumn(1)
                        .HEnd(),


                    new BoxView()
                        .GridRow(3)
                        .GridColumnSpan(2)
                        .Color(Color.Parse("#a0a0a0"))
                        .Margin(0)
                        .HeightRequest(1)
                        .HFill(),
                    
                    new Label("Total")
                        .GridRow(4)
                        .GridColumn(0),
                    new Label("$1,788.77")
                        .GridRow(4)
                        .GridColumn(1)
                        .HEnd(),
                }
                .HFill()
                .RowSpacing(10),


            }
        }
        .BackgroundColor(Colors.MistyRose)
        .GridRow(2);

    VisualNode BottomBar()
        => new Grid("Auto Auto", "* Auto Auto")
        {
            new Label("INV-791078")
                .GridRow(0)
                .GridColumn(0)
                .FontAttributes(MauiControls.FontAttributes.Bold)
                .TextColor(Colors.Black),
            new Label("Due in 7 Days ")
                .GridRow(1)
                .GridColumn(0)
                .TextColor(Color.Parse("#9d9d9d")),

            new ImageButton()
                .GridRow(0)
                .GridColumn(1)
                .GridRowSpan(2)
                .BackgroundColor(Colors.White)
                .CornerRadius(18)
                .WidthRequest(60)
                .HeightRequest(32)
                .BorderWidth(2)
                .BorderColor(Color.Parse("#dcdcdc"))
                .Margin(0,0,15,0)
                .Source("glasses.png"),
            new ImageButton()
                .GridRow(0)
                .GridColumn(2)
                .GridRowSpan(2)
                .BackgroundColor(Colors.Black)
                .CornerRadius(18)
                .WidthRequest(60)
                .HeightRequest(32)
                .Source("telegram.png")
        }
        .GridRow(0)
        .HeightRequest(100)
        .Margin(0,0,0,-30)
        .Padding(24, 10)
        .VerticalOptions(MauiControls.LayoutOptions.End)
        .BackgroundColor(Colors.White);

}