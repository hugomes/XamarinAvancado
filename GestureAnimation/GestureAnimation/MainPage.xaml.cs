using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureAnimation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Gestures
            // Tap - Toque\Click
            // Pinch - Pinça - Zoom em imagens
            // Pan - Segurar e arrastar - Mover objetos na tela

            PanGestureRecognizer pan = new PanGestureRecognizer();
            pan.PanUpdated += PanGestureRecognizer_Pan;
            lbPrincipal.GestureRecognizers.Add(pan);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //DisplayAlert("Tapped", "Label pressionada!", "Fechar");
            //bvMyBox.TranslateTo(200, 350, 1000, Easing.BounceOut);
            //bvMyBox.ScaleTo(2, 1000);
            //bvMyBox.FadeTo(0.5, 1000);
            //bvMyBox.RotateTo(90, 1000);

            var anim = new Animation(v=> bvMyBox.WidthRequest = v, 50, 100);
            anim.Commit(this, "animação", 16, 1000);

        }

        private void PanGestureRecognizer_Pan(object sender, PanUpdatedEventArgs e)
        {
            if (e.StatusType == GestureStatus.Running)
            {
                var PosX = lbPrincipal.X + e.TotalX;
                var PosY = lbPrincipal.Y + e.TotalY;

                Rectangle rect = new Rectangle(PosX, PosY, 50, 50);

                AbsoluteLayout.SetLayoutBounds(lbPrincipal, rect);
                AbsoluteLayout.SetLayoutFlags(lbPrincipal, AbsoluteLayoutFlags.None);

            }



            //switch (e.StatusType)
            //{
            //    case GestureStatus.Running:
            //        // Translate and ensure we don't pan beyond the wrapped user interface element bounds.
            //        lbPrincipal.TranslationX =
            //          Math.Max(Math.Min(0, x + e.TotalX), -Math.Abs(lbPrincipal.Width - Application.Current.MainPage.Width));
            //        lbPrincipal.TranslationY =
            //          Math.Max(Math.Min(0, y + e.TotalY), -Math.Abs(lbPrincipal.Height - Application.Current.MainPage.Height));
            //        break;

            //    case GestureStatus.Completed:
            //        // Store the translation applied during the pan
            //        x = lbPrincipal.TranslationX;
            //        y = lbPrincipal.TranslationY;
            //        break;
            //}


        }
    }
}
