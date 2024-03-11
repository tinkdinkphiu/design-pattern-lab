using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class ShapeFactory
    {
        public Shape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.VT:
                    return new LeftRTriangle();
                case ShapeType.VP:
                    return new RightRTriangle();
                case ShapeType.C:
                    return new IsoscelesTriangle();
                case ShapeType.D:
                    return new EquilateralTriangle();
                case ShapeType.T:
                    return new Circle();
                case ShapeType.CN:
                    return new RectangleShape();
                case ShapeType.V:
                    return new Square();
                default:
                    return null;
            }
        }
    }
}
