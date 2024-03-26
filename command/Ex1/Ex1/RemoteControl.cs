using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class RemoteControl
    {
        public List<CommandBase> onCommands = new List<CommandBase>();
        public List<CommandBase> offCommands = new List<CommandBase>();
        public Stack<Tuple<CommandBase, string>> undoCommands = new Stack<Tuple<CommandBase, string>>();
        public Stack<Tuple<CommandBase, string>> redoCommands = new Stack<Tuple<CommandBase, string>>();

        public void OnButtonWasPushed(int slot)
        {
            if (slot < onCommands.Count)
            {
                onCommands[slot].ExecuteOn();
                undoCommands.Push(Tuple.Create(onCommands[slot], "on"));
                redoCommands.Clear();
            }
        }

        public void OffButtonWasPushed(int slot)
        {
            if (slot < offCommands.Count)
            {
                offCommands[slot].ExecuteOff();
                undoCommands.Push(Tuple.Create(offCommands[slot], "off"));
                redoCommands.Clear();
            }
        }

        public void UndoButtonWasPushed()
        {
            if (undoCommands.Count == 0)
            {
                Console.WriteLine("Nothing to undo");
                return;
            }

            var commandState = undoCommands.Pop();
            if (commandState.Item2 == "on")
            {
                commandState.Item1.ExecuteOff();
            }
            else
            {
                commandState.Item1.ExecuteOn();
            }
            redoCommands.Push(commandState);
        }

        public void RedoButtonWasPushed()
        {
            if (redoCommands.Count == 0)
            {
                Console.WriteLine("Nothing to redo");
                return;
            }

            var commandState = redoCommands.Pop();
            if (commandState.Item2 == "on")
            {
                commandState.Item1.ExecuteOn();
            }
            else
            {
                commandState.Item1.ExecuteOff();
            }
            undoCommands.Push(commandState);
        }
    }
}
