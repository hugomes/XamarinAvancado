using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomControlXamarinForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MyControl_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Sou um evento.", myControl.Titulo, "Fechar");
        }
    }
}
