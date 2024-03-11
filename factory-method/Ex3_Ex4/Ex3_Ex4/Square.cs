using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Ex4
{
    internal class Square : Shape
    {
        private Point getPoint()
        {
            var diffX = Math.Abs(pointA.X - pointB.X);
            var diffY = Math.Abs(pointA.Y - pointB.Y);
            var minPoint = Math.Min(diffX, diffY);
            return new Point(pointA.X + minPoint, pointA.Y + minPoint);
        }
        public override void Draw(Graphics graphics)
        {
            var point = getPoint();
            var edge = Math.Abs(point.X - pointA.X);
            var square = new Rectangle(pointA.X, Math.Min(pointA.Y, pointB.Y), edge, edge);
            switch (shapeStyle)
            {
                case ShapeStyle.Solid:
                    graphics.DrawRectangle(new Pen(color), square);
                    break;
                case ShapeStyle.Dotted:
                    Pen dottedPen = new Pen(this.color) { DashStyle = DashStyle.Dash };
                    graphics.DrawRectangle(dottedPen, square);
                    break;
                case ShapeStyle.Fill:
                    Brush brush = new SolidBrush(this.color);
                    graphics.FillRectangle(brush, square);
                    break;
            }
        }
        public override bool IsInside(Point point)
        {
            var p = getPoint();
            var edge = Math.Abs(p.X - pointA.X);

            if (pointA.Y > pointB.Y)
            {
                var topLeftPoint = pointA;
                var bottomRightPoint = new Point(pointA.X + edge, pointA.Y - edge);

                var minX = topLeftPoint.X;
                var maxX = bottomRightPoint.X;
                var minY = bottomRightPoint.Y;
                var maxY = topLeftPoint.Y;
                return point.X >= minX && point.X <= maxX && point.Y >= minY && point.Y <= maxY;
            }
            else
            {
                var topLeftPoint = pointB;
                var bottomRightPoint = new Point(pointB.X + edge, pointB.Y - edge);

                var minX = topLeftPoint.X;
                var maxX = bottomRightPoint.X;
                var minY = bottomRightPoint.Y;
                var maxY = topLeftPoint.Y;
                return point.X >= minX && point.X <= maxX && point.Y >= minY && point.Y <= maxY;
            }
        }
    }
}
