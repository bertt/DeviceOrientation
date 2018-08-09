using OrientationApp;
using OrientationApp.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BertView), typeof(UIBertRenderer))]

namespace OrientationApp.iOS
{
    public class UIBertRenderer : ViewRenderer<BertView, UIBertView>
    {
        UIBertView uiBertView;

        protected override void OnElementChanged(ElementChangedEventArgs<BertView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                uiBertView = new UIBertView();
                SetNativeControl(uiBertView);
            }

        }
    }
}