using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class UndoCommand : ICommand
    {
        private Undo undo;
        public UndoCommand(Undo _undo)
        {
            undo = _undo;
        }
        public bool CanExecute()
        {
            if (undo != null)
            {
                return true;
            }
            return false;
        }

        public void Execute()
        {
            undo.UndoExecute();
        }
    }
}
