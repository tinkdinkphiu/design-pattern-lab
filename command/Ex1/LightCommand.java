public class LightCommand extends CommandBase {
    private Light light;

    public LightCommand(Light light) {
        this.light = light;
    }

    @Override
    public void executeOn() {
        this.light.on();
        this.state = CommandState.ON;
    }

    @Override
    public void executeOff() {
        this.light.off();
        this.state = CommandState.OFF;
    }

    @Override
    public void undo() {
        if(this.state == CommandState.ON) {
            this.executeOff();
        } else {
            this.executeOn();
        }
    }

    @Override
    public void redo() {
        if (this.state == CommandState.ON) {
            this.executeOn();
        } else {
            this.executeOff();
        }
    }
}