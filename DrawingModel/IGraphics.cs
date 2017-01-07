using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    interface IGraphics
    {
        //Draw a rectangle
        void DrawRectangle(double x1, double y1, double x2, double y2);

        //Draw a triangle
        void DrawTriangle(double x1, double y1, double x2, double y2);

        //Draw a circle
        void DrawCircle(double x1, double y1, double x2, double y2);

        //Draw a line
        void DrawLine(double x1, double y1, double x2, double y2);

        //Clear all graphics
        void ClearAll();
    }
}
