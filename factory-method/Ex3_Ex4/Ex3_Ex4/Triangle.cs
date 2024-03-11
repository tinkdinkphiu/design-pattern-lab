using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Ex4
{
    public abstract class Triangle : Shape
    {
        public abstract Point GetPoint1();
        public abstract Point GetPoint2();
        public abstract Point GetPoint3();
        public override void Draw(Graphics g)
        {
            Point p1 = GetPoint1();
            Point p2 = GetPoint2();
            Point p3 = GetPoint3();
            switch(shapeStyle)
            {
                case ShapeStyle.Solid:
                    g.DrawLine(new Pen(this.color), p1, p2);
                    g.DrawLine(new Pen(this.color), p2, p3);
                    g.DrawLine(new Pen(this.color), p1, p3);
                    break;
                case ShapeStyle.Dotted:
                    Pen dottedPen = new Pen(this.color) { DashStyle = DashStyle.Dash };
                    g.DrawLine(dottedPen, p1, p2);
                    g.DrawLine(dottedPen, p1, p3);
                    g.DrawLine(dottedPen, p2, p3);
                    break;
                case ShapeStyle.Fill:
                    Brush brush = new SolidBrush(this.color);
                    g.FillPolygon(brush, new Point[] { p1, p2, p3 });
                    break;
                default: break;
            }
            
        }
        public override bool IsInside(Point pointToCheck)
        {
            Point p1 = GetPoint1();
            Point p2 = GetPoint2();
            Point p3 = GetPoint3();

            float s = p1.Y * p3.X - p1.X * p3.Y + (p3.Y - p1.Y) * pointToCheck.X + (p1.X - p3.X) * pointToCheck.Y;
            float t = p1.X * p2.Y - p1.Y * p2.X + (p1.Y - p2.Y) * pointToCheck.X + (p2.X - p1.X) * pointToCheck.Y;

            if ((s < 0) != (t < 0))
                return false;

            float A = -p2.Y * p3.X + p1.Y * (p3.X - p2.X) + p1.X * (p2.Y - p3.Y) + p2.X * p3.Y;

            return A < 0 ? (s <= 0 && s + t >= A) : (s >= 0 && s + t <= A);
        }
    }
    public class LeftRTriangle : Triangle
    {
        public override Point GetPoint1()
        {
            if (pointA.X > pointB.X)
            {
                return new Point(pointB.X, pointA.Y);
            }
            return pointA;
        }

        public override Point GetPoint2()
        {
            return pointB;
        }

        public override Point GetPoint3()
        {
            return new Point(pointA.X, pointB.Y);
        }
    }
    public class RightRTriangle : Triangle
    {
        public override Point GetPoint1()
        {
            if (pointA.X > pointB.X)
            {
                return pointA;
            }
            return new Point(pointA.X, pointB.Y);
        }

        public override Point GetPoint2()
        {
            return pointB;
        }

        public override Point GetPoint3()
        {
            if (pointA.X > pointB.X)
            {
                return new Point(pointA.X, pointB.Y);
            }
            return new Point(pointB.X, pointA.Y);
        }
    }
    public class IsoscelesTriangle : Triangle
    {
        public override Point GetPoint1()
        {
            return new Point((pointA.X + pointB.X) / 2, pointA.Y);
        }

        public override Point GetPoint2()
        {
            return pointB;
        }

        public override Point GetPoint3()
        {
            return new Point(pointA.X, pointB.Y);
        }
    }
    public class EquilateralTriangle : Triangle
    {
        private const float Angle = (float)(Math.PI / 3);
        public override Point GetPoint1()
        {
            return pointA;
        }

        public override Point GetPoint2()
        {
            float side = (float)Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2));
            float x = pointA.X + side * (float)Math.Cos(Angle);
            float y = pointA.Y + side * (float)Math.Sin(Angle);
            if (pointA.Y > pointB.Y)
            {
                y = pointA.Y - side * (float)Math.Sin(Angle);
            }
            return new Point((int)x, (int)y);
        }

        public override Point GetPoint3()
        {
            float side = (float)Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2));
            float x = pointA.X + side * (float)Math.Cos(Angle + Angle);
            float y = pointA.Y + side * (float)Math.Sin(Angle + Angle);
            if (pointA.Y > pointB.Y)
            {
                y = pointA.Y - side * (float)Math.Sin(Angle + Angle);
            }
            return new Point((int)x, (int)y);
        }
    }
}
