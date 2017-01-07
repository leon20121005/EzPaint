using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class MoveCommand : ICommand
    {
        public MoveCommand(Model model, Shape shape, double shiftX, double shiftY)
        {
            _model = model;
            _shape = shape;
            _shiftX = shiftX;
            _shiftY = shiftY;
        }

        //Implement executing the command
        public void Execute()
        {
            _shape.X1 += _shiftX;
            _shape.Y1 += _shiftY;
            _shape.X2 += _shiftX;
            _shape.Y2 += _shiftY;
            _model.RemoveShape(_shape);
            _model.AddShape(_shape);
        }

        //Implement unexecuting the command
        public void Unexecute()
        {
            _shape.X1 -= _shiftX;
            _shape.Y1 -= _shiftY;
            _shape.X2 -= _shiftX;
            _shape.Y2 -= _shiftY;
            _model.RemoveShape(_shape);
            _model.AddShape(_shape);
        }

        private Model _model;
        private Shape _shape;
        private double _shiftX;
        private double _shiftY;
    }
}
