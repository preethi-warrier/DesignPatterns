using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    //Receiver
    public class Undo 
    {
        public void UndoExecute()
        {
            Console.WriteLine("Undo executed");
        }
    }
}
