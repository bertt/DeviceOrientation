using Android.Content;
using Android.Graphics;
using Android.Views;

namespace OrientationApp.Droid
{
    public class UIBertView : View
    {
        public UIBertView(Context context)
    : base(context)
        {
            var p = 0;

        }


        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);

            int x = 80;
            int y = 80;
            int radius = 40;
            var paint = new Paint();
            // Use Color.parseColor to define HTML colors
            paint.Color = Color.ParseColor("#CD5C5C");
            canvas.DrawCircle(x, x, radius, paint);
        }

    }
}