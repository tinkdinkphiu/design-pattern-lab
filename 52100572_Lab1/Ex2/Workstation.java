public class Workstation extends Node {
    public Workstation(String name) {
        super(name);
    }

    public boolean accept(Packet p) {
        return this.originates(p) && nextNode.accept(p);
    }

    public boolean originates(Packet p) {
        return p.getOriginator().equals(this.name);
    }

    public void originate(Packet p) {
        accept(p);
    }
}