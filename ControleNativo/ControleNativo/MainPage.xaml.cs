using Xamarin.Forms;

#if __ANDROID__
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Android.Support.Design.Widget;
#endif

#if __IOS__
using UIKit;
using Xamarin.Forms.Platform.iOS;
#endif


namespace ControleNativo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
#if __ANDROID__
            TextView labelAndroid = new TextView(Forms.Context){Text = "Android Nativo!"};
            Container.Children.Add(labelAndroid);

            FloatingActionButton fab = new FloatingActionButton(Forms.Context);
            fab.SetImageResource(Droid.Resource.Mipmap.icon);
            ContainerAbs.Children.Add(fab);

            fab.Click += delegate{
                DisplayAlert("Alerta", "Clicou!", "Fechar");
            };
#endif

#if __IOS__
            UILabel labelIOS = new UILabel(){Text = "IOS Nativo!"};
            Container.Children.Add(labelIOS);
#endif
        }
    }
}
