using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
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
            var Rectangle = new Rectangle(pointA, new Size(edge, edge));
            graphics.DrawRectangle(new Pen(color, 1), Rectangle);
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

                var isInsideX = point.X >= minX && point.X <= maxX;
                var isInsideY = point.Y >= minY && point.Y <= maxY;

                return isInsideX && isInsideY;
            }
            else
            {
                var topLeftPoint = pointB;
                var bottomRightPoint = new Point(pointB.X + edge, pointB.Y - edge);

                var minX = topLeftPoint.X;
                var maxX = bottomRightPoint.X;
                var minY = bottomRightPoint.Y;
                var maxY = topLeftPoint.Y;

                var isInsideX = point.X >= minX && point.X <= maxX;
                var isInsideY = point.Y >= minY && point.Y <= maxY;

                return isInsideX && isInsideY;
            }
        }
    }
}
