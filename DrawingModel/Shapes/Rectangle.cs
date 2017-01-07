using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class Rectangle : Shape
    {
        //Override the drawing method to draw a rectangle
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawRectangle(X1, Y1, X2, Y2);
        }

        //Override the method to determine if the rectangle is selected
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
    