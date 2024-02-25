public class Printer extends Node {
    private static Printer instance;

    private Printer(String name) {
        super(name);
    }

    public static Printer getInstance() {
        if (instance == null) {
            instance = new Printer("Printer");
        }
        return instance;
    }

    public boolean accept(Packet p) {
        return print(p);
    }

    public boolean print(Packet p) {
        if (p.isForPrinter()) {
            System.out.println("Printer " + name + " đang in: " + p.getContents());
            return true;
        } else {
            System.out.println("Printer " + name + " không thể in: " + p.getDestination());
            return false;
        }
    }    
}