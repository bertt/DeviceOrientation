using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using OrientationApp.Droid;
using Android.Content;
using OrientationApp;

[assembly: ExportRenderer(typeof(BertView), typeof(UIBertRenderer))]
namespace OrientationApp.Droid
{
    public class UIBertRenderer:ViewRenderer<BertView, UIBertView>
    {
        UIBertView uiBertView;

        public UIBertRenderer(Context context) : base(context)
        {
            var p = 0;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<BertView> e)
        {
            var p = 0;
            base.OnElementChanged(e);

            if (Control == null)
            {
                uiBertView = new UIBertView(Context);
                SetNativeControl(uiBertView);
            }

        }
    }
}