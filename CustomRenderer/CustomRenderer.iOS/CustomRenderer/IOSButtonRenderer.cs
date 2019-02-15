using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomRenderer.Customs.MyButton), typeof(CustomRenderer.iOS.CustomRenderer.IOSButtonRenderer))]
namespace CustomRenderer.iOS.CustomRenderer
{
    public class IOSButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Layer.CornerRadius = 10; // this value vary as per your desire
                Control.ClipsToBounds = true;
                Control.BackgroundColor = UIColor.Blue;
            }
        }
    }
}