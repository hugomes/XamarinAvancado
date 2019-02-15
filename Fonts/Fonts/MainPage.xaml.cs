using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Fonts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
            {
                lbPrincipal.FontFamily = "dacasa.ttf#dacasa";
            }
            else if (Device.RuntimePlatform == Device.iOS)
            {
                lbPrincipal.FontFamily = "dacasa";
            }
            else if (Device.RuntimePlatform == Device.UWP)
            {
                lbPrincipal.FontFamily = "Assets/Fonts/dacasa.ttf#dacasa";
            }
        }
    }
}
