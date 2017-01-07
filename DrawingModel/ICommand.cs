using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    interface ICommand
    {
        //Execute the command
        void Execute();

        //Unexecute the command
        void Unexecute();
    }
}
