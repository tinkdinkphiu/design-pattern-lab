namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            Fan fan = new Fan();

            LightCommand lightCommand = new LightCommand(light);
            FanCommand fanCommand = new FanCommand(fan);

            RemoteControl remoteControl = new RemoteControl();

            remoteControl.onCommands.Add(lightCommand);
            remoteControl.offCommands.Add(lightCommand);

            remoteControl.onCommands.Add(fanCommand);
            remoteControl.offCommands.Add(fanCommand);

            remoteControl.OnButtonWasPushed(0); // Light
            remoteControl.OffButtonWasPushed(0); // Light

            remoteControl.OnButtonWasPushed(1); // Fan
            remoteControl.OffButtonWasPushed(1); // Fan

            remoteControl.UndoButtonWasPushed();
            remoteControl.RedoButtonWasPushed();

            remoteControl.UndoButtonWasPushed();
            remoteControl.RedoButtonWasPushed();
        }
    }
}
