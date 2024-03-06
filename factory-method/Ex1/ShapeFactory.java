public class ShapeFactory {
    public static IShape createShape(String shapeType, String style) {
        if (style.equals("solid")) {
            switch (shapeType) {
                case "circle":
                    return new SolidCircle();
                case "rectangle":
                    return new SolidRectangle();
                case "square":
                    return new SolidSquares();
                default:
                    throw new IllegalArgumentException("Invalid shape type for solid style");
            }
        } else {
            switch (shapeType) {
                case "circle":
                    return new Circle();
                case "rectangle":
                    return new Rectangle();
                case "square":
                    return new Squares();
                default:
                    throw new IllegalArgumentException("Invalid shape type for normal style");
            }
        }
    }
}
