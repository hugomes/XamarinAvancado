using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomControlXamarinForms.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyControl : ContentView
	{
        public event EventHandler Tapped;

        #region Titulo
        public static readonly BindableProperty TituloProperty = BindableProperty.Create(
            propertyName: "Titulo",
            returnType: typeof(string),
            declaringType: typeof(MyControl),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: TituloPropertyChanged
        );

        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        private static void TituloPropertyChanged(BindableObject bindable, Object oldValue, Object newValue)
        {
            var myControl = (MyControl)bindable;

            myControl.txtNome.Text = (string)newValue;
        }
        #endregion

        #region TituloCor
        public static readonly BindableProperty TituloCorProperty = BindableProperty.Create(
            propertyName: "TituloCor",
            returnType: typeof(Color),
            declaringType: typeof(MyControl),
            defaultValue: Color.Black,
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: TituloCorPropertyChanged
        );

        public Color TituloCor
        {
            get { return (Color)GetValue(TituloCorProperty); }
            set { SetValue(TituloCorProperty, value); }
        }

        private static void TituloCorPropertyChanged(BindableObject bindable, Object oldValue, Object newValue)
        {
            var myControl = (MyControl)bindable;
            myControl.txtNome.TextColor = (Color)newValue;
        }
        #endregion

        #region Image
        public static readonly BindableProperty ImageProperty = BindableProperty.Create(
            propertyName: "Imagem",
            returnType: typeof(string),
            declaringType: typeof(MyControl),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: ImageSourcePropertyChanged
        );

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        private static void ImageSourcePropertyChanged(BindableObject bindable, Object oldValue, Object newValue)
        {
            var myControl = (MyControl)bindable;
            myControl.imgImagem.Source = ImageSource.FromFile((string)newValue);
        }
        #endregion


        public MyControl ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Tapped != null)
            {
                //Tapped(this, EventArgs.Empty);
                Tapped(sender, e);
            }
        }
    }
}