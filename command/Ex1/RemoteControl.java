import java.util.Stack;

public class RemoteControl {
    public Stack<CommandBase> undoCommands = new Stack<>();
    public Stack<CommandBase> redoCommands = new Stack<>();

    public void onButtonWasPushed(CommandBase command) {
        command.executeOn();
        undoCommands.push(command);
        redoCommands.clear();
    }

    public void offButtonWasPushed(CommandBase command) {
        command.executeOff();
        undoCommands.push(command);
        redoCommands.clear();
    }

    public void undoButtonWasPushed() {
        if (!undoCommands.isEmpty()) {
            CommandBase command = undoCommands.pop();
            command.undo();
            redoCommands.push(command);
        }
    }

    public void redoButtonWasPushed() {
        if (!redoCommands.isEmpty()) {
            CommandBase command = redoCommands.pop();
            command.redo();
            undoCommands.push(command);
        }
    }
}
