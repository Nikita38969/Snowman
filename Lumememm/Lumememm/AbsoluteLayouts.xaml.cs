using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumememm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLayouts : ContentPage
    {
        public AbsoluteLayouts()
        {

            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.LightBlue },
                new Rectangle(70, 70, 200, 70)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "The snowman", FontSize = 20 },
                new Rectangle(110, 90, 150, 60)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Red, CornerRadius = 30 },
                new Point(70, 150)
            );

          
            
            Content = absoluteLayout;
        }
    }
}