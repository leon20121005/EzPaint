using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class Triangle : Shape
    {
        //Override the drawing method to draw a triangle
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawTriangle(X1, Y1, X2, Y2);
        }

        //Override the method to determine if the triangle is selected

        //Barycentric coordinate system
        //Wikipedia: https://zh.wikipedia.org/wiki/%E9%87%8D%E5%BF%83%E5%9D%90%E6%A0%87
        public override bool IsSelected(double pointX, double pointY)
        {
            double point2X = (X1 + X2) / 2;

            double alpha = ((Y1 - Y2)*(pointX - X2) + (X2 - point2X) *(pointY - Y2)) / ((Y1 - Y2)*(X1 - X2) + (X2 - point2X) *(Y2 - Y2));
            double beta = ((Y2 - Y2)*(pointX - X2) + (X1 - X2)*(pointY - Y2)) / ((Y1 - Y2)*(X1 - X2) + (X2 - point2X) *(Y2 - Y2));
            double gamma = 1 - alpha - beta;

            if (alpha > 0 && beta > 0 && gamma > 0)
            {
                return true;
            }
            return false; 
        }
    }
}
