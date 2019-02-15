using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DetectSODevice
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if(Device.OS == TargetPlatform.Android)
            {
                lbMain.Text = "Plataforma Android";
            }

            if(Device.Idiom == TargetIdiom.Phone)
            {
                lbMain.Text += " com celular";
            }

            Device.OnPlatform(
                Android: () => {
                    lbMain.TextColor = Color.Blue;
                },
                iOS: () => {
                    
                }
                );

            if (Device.OS == TargetPlatform.iOS)
                Container.Margin = new Thickness(0, 10, 0, 0);
        }
    }
}
