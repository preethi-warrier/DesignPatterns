using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Invoker
            //Normally invoker could be a 
            //GUI action like undo button click

            Undo undo = new Undo();
            ICommand undoCommand = new UndoCommand(undo);
            if(undoCommand.CanExecute())
            {
                undoCommand.Execute();
            }

            Redo redo = new Redo();
            ICommand redoCommand = new RedoCommand(redo);
            if (redoCommand.CanExecute())
            {
                redoCommand.Execute();
            }
        }
    }
}
