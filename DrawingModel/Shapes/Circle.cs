using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class Circle : Shape
    {
        //Override the drawing method to draw a circle
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawCircle(X1, Y1, X2, Y2);
        }

        //Override the method to determine if the circle is selected

        //Ellipse center point: (h, k)
        //Ellipse equation: if a // x-axis, b // y-axis => (x - h) ^ 2 / a ^ 2 + (y - k) ^ 2 / b ^ 2 = 1, a >= b > 0 
        //                  if a // y-axis, b // x-axis => (y - k) ^ 2 / a ^ 2 + (x - h) ^ 2 / b ^ 2 = 1, a >= b > 0

        //Ellipse includes circle (condition a = b)
        //Inside the ellipse: left hand side of the equation <= right hand side of the equation

        //Wikipedia: https://zh.wikipedia.org/wiki/%E6%A4%AD%E5%9C%86
        public override bool IsSelected(double pointX, double pointY)
        {
            double centerPointX = (X1 + X2) / 2;
            double centerPointY = (Y1 + Y2) / 2;

            if (((X2 - X1) / 2) >= ((Y2 - Y1) / 2))
            {
                double a = (X2 - X1) / 2;
                double b = (Y2 - Y1) / 2;
                if (Math.Pow((pointX - centerPointX), 2) / Math.Pow(a, 2) + Math.Pow((pointY - centerPointY), 2) / Math.Pow(b, 2) <= 1)
                {
                    return true;
                }
            }
            if (((X2 - X1) / 2) < ((Y2 - Y1) / 2))
            {
                double a = (Y2 - Y1) / 2;
                double b = (X2 - X1) / 2;
                if (Math.Pow((pointY - centerPointY), 2) / Math.Pow(a, 2) + Math.Pow((pointX - centerPointX), 2) / Math.Pow(b, 2) <= 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
