using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class DrawCommand : ICommand
    {
        public DrawCommand(Model model, Shape shape)
        {
            _model = model;
            _shape = shape;
        }

        //Implement executing the command
        public void Execute()
        {
            _model.AddShape(_shape);
        }

        //Implement unexecuting the command
        public void Unexecute()
        {
            _model.RemoveLastShape();
        }

        private Model _model;
        private Shape _shape;
    }
}
