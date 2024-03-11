using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class RectangleShape : Shape
    {
        public override void Draw(Graphics graphics)
        {
            var sideA = Math.Abs(pointA.X - pointB.X);
            var sideB = Math.Abs(pointA.Y - pointB.Y);
            var Rectangle = new Rectangle(pointA, new Size(sideA, sideB));
            graphics.DrawRectangle(new Pen(color), Rectangle);
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
