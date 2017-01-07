using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class CommandManager
    {
        //Execute the command
        public void Execute(ICommand command)
        {
            command.Execute();
            _undoStack.Push(command);
            _redoStack.Clear();          
        }

        //Undo the last action
        public void Undo()
        {
            if (_undoStack.Count <= 0)
            {
                throw new Exception("Cannot Undo exception\n");
            }
            ICommand command = _undoStack.Pop();
            _redoStack.Push(command);
            command.Unexecute();
        }

        //Redo the last action
        public void Redo()
        {
            if (_redoStack.Count <= 0)
            {
                throw new Exception("Cannot Redo exception\n");
            }
            ICommand command = _redoStack.Pop();
            _undoStack.Push(command);
            command.Execute();
        }

        //Return the enabled state of the undo button
        public bool IsUndoEnabled
        {
            get
            {
                return _undoStack.Count != 0;
            }
        }

        //Return the enabled state of the redo button
        public bool IsRedoEnabled
        {
            get
            {
                return _redoStack.Count != 0;
            }
        }

        private Stack<ICommand> _undoStack = new Stack<ICommand>();
        private Stack<ICommand> _redoStack = new Stack<ICommand>();
    }
}
