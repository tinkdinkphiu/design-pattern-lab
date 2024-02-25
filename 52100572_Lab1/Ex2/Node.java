public class Node {
    protected String name;
    protected Node nextNode;

    public Node(String name) {
        this.name = name;
    }

    public boolean accept(Packet p) {
        if (nextNode != null) {
            return nextNode.accept(p);
        } else {
            return false;
        }
    }

    public void setNextNode(Node nextNode) {
        this.nextNode = nextNode;
    }
}
