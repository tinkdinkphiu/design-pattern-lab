using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public abstract class Shape
    {
        public Point pointA { get; set; }
        public Point pointB { get; set; }
        public Color color { get; set; } = Color.Black;
        public abstract void Draw(Graphics g);
        public abstract bool IsInside(Point point);
        public float Distance(Point pointA, Point pointB)
        {
            return (float)Math.Sqrt(Math.Pow(pointA.X - pointB.X, 2) - Math.Pow(pointA.Y - pointB.Y, 2));
        }
    }
    public enum ShapeType
    {
        VT, VP, D, C, T, CN, V
    }
}
