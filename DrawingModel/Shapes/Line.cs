using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class Line : Shape
    {
        //Override the drawing method to draw a line
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawLine(X1, Y1, X2, Y2);
        }

        //Override the method to determine if the line is selected
        public override bool IsSelected(double pointX, double pointY)
        {
            if (pointX <= X2 && pointX >= X1 && pointY <= Y2 && pointY >= Y1)
            {
                return true;
            }
            return false;
        }
    }
}
