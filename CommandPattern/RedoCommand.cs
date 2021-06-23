using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class RedoCommand : ICommand
    {
        private Redo redo;
        public RedoCommand(Redo _redo)
        {
            redo = _redo;
        }
        public bool CanExecute()
        {
            if(redo != null)
            {
                return true;
            }
            return false;
        }

        public void Execute()
        {
            redo.RedoExecute();
        }
    }
}
