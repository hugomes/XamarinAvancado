using MultiLanguages.Translate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MultiLanguages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Lang.AppLang.Culture = DependencyService.Get<ILocale>().GetCurrentCultureInfo();
            lbPrincipal.Text = Lang.AppLang.MSG_01;
        }
    }
}
