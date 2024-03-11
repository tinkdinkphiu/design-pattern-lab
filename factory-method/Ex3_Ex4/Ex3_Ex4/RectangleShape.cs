using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Ex4
{
    internal class RectangleShape : Shape
    {
        public override void Draw(Graphics graphics)
        {
            var sideA = Math.Abs(pointA.X - pointB.X);
            var sideB = Math.Abs(pointA.Y - pointB.Y);
            var rectangle = new Rectangle(Math.Min(pointA.X, pointB.X), Math.Min(pointA.Y, pointB.Y), sideA, sideB);

            switch (shapeStyle)
            {
                case ShapeStyle.Solid:
                    graphics.DrawRectangle(new Pen(color), rectangle);
                    break;
                case ShapeStyle.Dotted:
                    Pen dottedPen = new Pen(this.color) { DashStyle = DashStyle.Dash };
                    graphics.DrawRectangle(dottedPen, rectangle);
                    break;
                case ShapeStyle.Fill:
                    Brush brush = new SolidBrush(this.color);
                    graphics.FillRectangle(brush, rectangle);
                    break;
            }
        }

        public override bool IsInside(Point point)
        {
            var minATopLeft = Math.Min(pointA.X, pointB.X);
            var minBTopLeft = Math.Min(pointA.Y, pointB.Y);
            var minABotRight = Math.Max(pointA.X, pointB.X);
            var minBBotRight = Math.Max(pointA.Y, pointB.Y);

            var topLeftPoint = new Point(minATopLeft, minBTopLeft);
            var botRightPoint = new Point(minABotRight, minBBotRight);

            var isInsideX = point.X >= topLeftPoint.X && point.X <= botRightPoint.X;
            var isInsideY = point.Y >= topLeftPoint.Y && point.Y <= botRightPoint.Y;

            return isInsideX && isInsideY;
        }
    }
}
