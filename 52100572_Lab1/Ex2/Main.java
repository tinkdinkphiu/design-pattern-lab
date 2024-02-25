public class Main {
    public static void main(String[] args) {
        Server server = Server.getInstance();

        Workstation workstation1 = new Workstation("Workstation1");
        workstation1.setNextNode(server);

        Workstation workstation2 = new Workstation("Workstation2");
        workstation2.setNextNode(server);

        Packet packet1 = new Packet("Workstation1", "Server", "Nội dung từ Workstation1");
        workstation1.originate(packet1);

        Packet packet2 = new Packet("Workstation2", "Server", "Nội dung từ Workstation2");
        workstation2.originate(packet2);
    }
}
