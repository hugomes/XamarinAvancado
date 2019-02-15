using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(CustomRenderer.Customs.MyButton), typeof(CustomRenderer.Droid.CustomRenderer.AndroidButtonRenderer))]
namespace CustomRenderer.Droid.CustomRenderer
{
    public class AndroidButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.SetBackgroundResource(Resource.Drawable.button_round);
            }
        }
    }
}