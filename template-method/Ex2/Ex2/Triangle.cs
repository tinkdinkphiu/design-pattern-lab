using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public abstract class Triangle
    {
        public Point pointA { get; set; }
        public Point pointB { get; set; }
        public Color Color { get; set; } = Color.Black;
        public void Draw(Graphics g)
        {
            Point p1 = GetPoint1();
            Point p2 = GetPoint2();
            Point p3 = GetPoint3();

            g.DrawLine(new Pen(Color), p1, p2);
            g.DrawLine(new Pen(Color), p2, p3);
            g.DrawLine(new Pen(Color), p1, p3);
        }
        public abstract Point GetPoint1();
        public abstract Point GetPoint2();
        public abstract Point GetPoint3();
        public bool IsInside(Point pointToCheck)
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
    public enum TriangleType
    {
        VT, VP, D, C,
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
            return new Point((int)x, (int)y);
        }

        public override Point GetPoint3()
        {
            float side = (float)Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2));
            float x = pointA.X + side * (float)Math.Cos(Angle + Angle);
            float y = pointA.Y + side * (float)Math.Sin(Angle + Angle);
            return new Point((int)x, (int)y);
        }
    }
    public class TriangleSimpleFactory
    {
        public Triangle CreateTriangle(TriangleType type) 
        {
            if (type == TriangleType.VT) return new LeftRTriangle();
            else if (type == TriangleType.VP) return new RightRTriangle();
            else if (type == TriangleType.C) return new IsoscelesTriangle();
            else if (type == TriangleType.D) return new EquilateralTriangle();
            else return null;
        }
    }
}