using System.ComponentModel;
using Android.Graphics;
using CustomControlNative.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomBoxView), typeof(CustomControlNative.Droid.Controls.CustomBoxViewRenderer))]
namespace CustomControlNative.Droid.Controls
{
    public class CustomBoxViewRenderer : BoxRenderer
    {
        private static int xPosicaoInicial = 50;
        private static int yPosicaoInicial = 100;
        public CustomBoxViewRenderer()
        {
            SetWillNotDraw(false);
        }

        public override void Draw(Canvas canvas)
        {
            base.Draw(canvas);

            CustomBoxView control = (CustomBoxView)Element;
            DrawCourt(canvas, control);
            DrawPlayers(canvas, control);

        }

        private static void DrawPlayers(Canvas canvas, CustomBoxView control)
        {
            int raduis = 30;

            Paint p = new Paint
            {
                StrokeWidth = (float)control.Espessura,
                Color = Android.Graphics.Color.Blue
            };

            canvas.DrawCircle(xPosicaoInicial + 50, yPosicaoInicial + 70, raduis, p);// jogador da 1 cima
            canvas.DrawCircle(xPosicaoInicial + 135, yPosicaoInicial + 70, raduis, p);// jogador da 6 cima
            canvas.DrawCircle(xPosicaoInicial + 220, yPosicaoInicial + 70, raduis, p);// jogador da 5 cima

            canvas.DrawCircle(xPosicaoInicial + 50, yPosicaoInicial + 220, raduis, p);// jogador da 2 cima
            canvas.DrawCircle(xPosicaoInicial + 135, yPosicaoInicial + 220, raduis, p);// jogador da 3 cima
            canvas.DrawCircle(xPosicaoInicial + 220, yPosicaoInicial + 220, raduis, p);// jogador da 4 cima

            canvas.DrawCircle(xPosicaoInicial + 50, yPosicaoInicial + 320, raduis, p);// jogador da 2 baixo
            canvas.DrawCircle(xPosicaoInicial + 135, yPosicaoInicial + 320, raduis, p);// jogador da 3 baixo
            canvas.DrawCircle(xPosicaoInicial + 220, yPosicaoInicial + 320, raduis, p);// jogador da 4 baixo

            canvas.DrawCircle(xPosicaoInicial + 50, yPosicaoInicial + 470, raduis, p);// jogador da 1 baixo
            canvas.DrawCircle(xPosicaoInicial + 135, yPosicaoInicial + 470, raduis, p);// jogador da 6 baixo
            canvas.DrawCircle(xPosicaoInicial + 220, yPosicaoInicial + 470, raduis, p);// jogador da 5 baixo
        }

        private static void DrawCourt(Canvas canvas, CustomBoxView control)
        {
            int largura = 270;

            Paint pCourt = new Paint
            {
                StrokeWidth = (float)control.Espessura,
                Color = Android.Graphics.Color.Orange                
            };

            Paint pLines = new Paint
            {
                StrokeWidth = (float)control.Espessura,
                Color = Android.Graphics.Color.White
            };

            canvas.DrawRect(xPosicaoInicial, yPosicaoInicial, xPosicaoInicial+largura, (largura*2) + yPosicaoInicial, pCourt);

            canvas.DrawLine(xPosicaoInicial, yPosicaoInicial, largura + xPosicaoInicial, yPosicaoInicial, pLines);// linha de cima
            canvas.DrawLine(xPosicaoInicial, (largura * 2) + yPosicaoInicial, largura + xPosicaoInicial, (largura * 2) + yPosicaoInicial, pLines);// linha de baixo

            canvas.DrawLine(xPosicaoInicial, yPosicaoInicial, xPosicaoInicial, (largura * 2) + yPosicaoInicial, pLines);// linha esquerda
            canvas.DrawLine(xPosicaoInicial + largura, yPosicaoInicial, xPosicaoInicial + largura, (largura * 2) + yPosicaoInicial, pLines);// linha direita

            canvas.DrawLine(xPosicaoInicial, yPosicaoInicial + largura, largura + xPosicaoInicial, yPosicaoInicial + largura, pLines);// linha central

            canvas.DrawLine(xPosicaoInicial, yPosicaoInicial + largura - (largura / 3), largura + xPosicaoInicial, yPosicaoInicial + largura - (largura / 3), pLines);// 3 metros superior
            canvas.DrawLine(xPosicaoInicial, yPosicaoInicial + largura + (largura / 3), largura + xPosicaoInicial, yPosicaoInicial + largura + (largura / 3), pLines);// 3 metros inferior
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Invalidate();
        }
    }
}