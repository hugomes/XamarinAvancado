using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomRenderer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button button = new Button();
            button.Text = "Meu botão";
            button.TextColor = Color.Coral;

            Container.Children.Add(button);
        }
    }
}
