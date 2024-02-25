public class Packet {
    private String originator;
    private String destination;
    private String contents;

    public Packet(String originator, String destination, String contents) {
        this.originator = originator;
        this.destination = destination;
        this.contents = contents;
    }

    public boolean isForOriginator(Node node) {
        return node instanceof Workstation && ((Workstation) node).originates(this);
    }

    public boolean isDestination(Node node) {
        return node instanceof Server && ((Server) node).accept(this);
    }

    public String getOriginator() {
        return originator;
    }

    public String getDestination() {
        return destination;
    }

    public String getContents() {
        return contents;
    }

    public void setDestination(String destination) {
        this.destination = destination;
    }
    
    public boolean isForPrinter() {
        return "Printer".equals(this.destination);
    }
}