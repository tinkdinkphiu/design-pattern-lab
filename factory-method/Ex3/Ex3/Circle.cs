using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Circle : Shape
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
            /*var point = getPoint();
            var edge = Math.Abs(point.X - A.X);
            var Rect = new Rectangle(A, new Size(edge, edge));
            graphics.DrawEllipse(new Pen(color, 1), Rect);*/

            var center = new Point((pointA.X + pointB.X) / 2, (pointA.Y + pointB.Y) / 2);
            var radius = Math.Sqrt(Math.Pow(pointA.X - center.X, 2) + Math.Pow(pointA.Y - center.Y, 2));

            var diameter = radius * 2;
            var topLeft = new Point(center.X - (int)Math.Floor(radius), center.Y - (int)Math.Floor(radius));
            var size = new Size((int)Math.Floor(diameter), (int)Math.Floor(diameter));
            var rectangle = new Rectangle(topLeft, size);

            graphics.DrawEllipse(new Pen(color), rectangle);
        }
        public override bool IsInside(Point point)
        {
            var center = new Point((pointA.X + getPoint().X) / 2, (pointA.Y + getPoint().Y) / 2);
            var radius = Math.Sqrt(Math.Pow(pointA.X - center.X, 2) + Math.Pow(pointA.Y - center.Y, 2));

            var distance = Math.Sqrt(Math.Pow(point.X - center.X, 2) + Math.Pow(point.Y - center.Y, 2));

            return distance < radius;
        }
    }
}
