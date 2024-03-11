using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Ex4
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
            var center = new Point((pointA.X + pointB.X) / 2, (pointA.Y + pointB.Y) / 2);
            var radius = Math.Sqrt(Math.Pow(pointA.X - center.X, 2) + Math.Pow(pointA.Y - center.Y, 2));

            var diameter = radius * 2;
            var topLeft = new Point(center.X - (int)Math.Floor(radius), center.Y - (int)Math.Floor(radius));
            var size = new Size((int)Math.Floor(diameter), (int)Math.Floor(diameter));
            var rectangle = new Rectangle(topLeft, size);

            switch(shapeStyle)
            {
                case ShapeStyle.Solid:
                    graphics.DrawEllipse(new Pen(color), rectangle);
                    break;
                case ShapeStyle.Dotted:
                    Pen dottedPen = new Pen(this.color) { DashStyle = DashStyle.Dash };
                    graphics.DrawEllipse(dottedPen, rectangle); 
                    break;
                case ShapeStyle.Fill:
                    Brush brush = new SolidBrush(this.color);
                    graphics.FillEllipse(brush, rectangle);
                    break;
                default: break;
            }
           
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
