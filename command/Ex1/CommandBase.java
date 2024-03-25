public abstract class CommandBase {
    public enum CommandState {
        ON, OFF
    }

    protected CommandState state = CommandState.OFF;

    public abstract void executeOn();
    public abstract void executeOff();

    public abstract void undo();

    public abstract void redo();
}
