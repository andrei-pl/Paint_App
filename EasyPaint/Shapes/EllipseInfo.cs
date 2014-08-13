using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPaint.Shapes
{
    [Serializable]
    class EllipseInfo : Shape
    {
        Point moveOriginStart;
        
        public EllipseInfo(Point startOrigin, int width, int height, Color chosenColor, int shapeSize, bool fillShape)

        {
            StartOrigin = startOrigin;
            Width = width;
            Height = height;
            ChosenColor = chosenColor;
            ShapeSize = shapeSize;
            moveOriginStart = startOrigin;
            FilledShape = fillShape;
        }

        public override void Draw(Graphics g)
        {
            SolidBrush tempBrush = new SolidBrush(ChosenColor);
            if (FilledShape)
            {
                g.FillEllipse(tempBrush, StartOrigin.X, StartOrigin.Y, Width, Height);
            }
            else
            {
                g.DrawEllipse(new Pen(ChosenColor, ShapeSize), StartOrigin.X, StartOrigin.Y, Width, Height);
            }
        }

        public override bool ContainsPoint(Point p)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(StartOrigin.X - 6, StartOrigin.Y - 6, Width + 15, Height + 15);
            bool pointWithinEllipse = myPath.IsVisible(p);

            if (pointWithinEllipse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
