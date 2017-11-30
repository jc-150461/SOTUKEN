using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace SOTUKEN
{
    public class TopPageCS : ContentPage
    {

        public TopPageCS()
        {
            Title = "Top";
            Icon = "TopIcon.png";
            Padding = new Thickness(0, 20, 0, 0);

            Content = new StackLayout
            {
                Children ={
                    new Label
                    {
                        Text = "Test",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
                    }
                }
            };
        }
    }
}


