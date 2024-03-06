public class DrawShape {
    public void draw(String shape, String style) {
        IShape shapeObj = ShapeFactory.createShape(shape, style);
        shapeObj.draw();
    }
}