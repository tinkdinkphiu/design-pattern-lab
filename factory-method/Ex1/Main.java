public class Main {
    public static void main(String[] args) {
        DrawShape drawShape = new DrawShape();

        drawShape.draw("circle", "solid");
        drawShape.draw("rectangle", "solid");
        drawShape.draw("square", "solid");

        drawShape.draw("circle", "unknown");
        drawShape.draw("rectangle", "normal");
        drawShape.draw("square", "default");
    }
}
