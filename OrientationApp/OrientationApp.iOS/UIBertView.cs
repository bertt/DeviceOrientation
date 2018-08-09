using CoreGraphics;
using UIKit;

namespace OrientationApp.iOS
{
    public class UIBertView : UIView
    {
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);

            var context = UIGraphics.GetCurrentContext();

            context.SetLineWidth(4);
            UIColor.Red.SetFill();
            UIColor.Blue.SetStroke();

            var path = new CGPath();
            var p1 = new CGPoint(100, 200);
            var p2 = new CGPoint(160, 100);
            var p3 = new CGPoint(220, 200);
            path.AddLines(new CGPoint[] { p1, p2, p3 });

            /**path.AddLines(new PointF[]{
            new PointF(100,200),
            new PointF(160,100),
            new PointF(220,200)});
            */

            path.CloseSubpath();

            context.AddPath(path);
            context.DrawPath(CGPathDrawingMode.FillStroke);

        }

    }
}