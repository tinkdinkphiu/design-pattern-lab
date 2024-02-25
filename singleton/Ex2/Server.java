public class Server extends Node {
    private static Server instance;

    private Server(String name) {
        super(name);
    }

    public static Server getInstance() {
        if (instance == null) {
            instance = new Server("Server");
        }
        return instance;
    }

    public boolean accept(Packet p) {
        p.setDestination("Printer");
        Printer printer = Printer.getInstance();
        return printer.accept(p);
    }
}