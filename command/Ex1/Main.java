public class Main {
    public static void main(String[] args) {
        Light light = new Light();
        LightCommand lightCommand = new LightCommand(light);
        RemoteControl remoteControl = new RemoteControl();

        remoteControl.onButtonWasPushed(lightCommand);
        remoteControl.offButtonWasPushed(lightCommand);

        remoteControl.undoButtonWasPushed();
        remoteControl.redoButtonWasPushed();

        remoteControl.undoButtonWasPushed();
        remoteControl.redoButtonWasPushed();
    }
}
