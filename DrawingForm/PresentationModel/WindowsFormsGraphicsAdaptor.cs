using System.Drawing;
using DrawingModel;

namespace DrawingForm
{
    class WindowsFormsGraphicsAdaptor : IGraphics
    {
        public WindowsFormsGraphicsAdaptor(Graphics graphics)
        {
            _graphics = graphics;
        }

        //Implement drawing a rectangle
        public void DrawRectangle(double x1, double y1, double x2, double y2)
        {
            Point[] points = new Point[4];
            points[0] = new Point((int)x1, (int)y1);
            points[1] = new Point((int)x2, (int)y1);
            points[2] = new Point((int)x2, (int)y2);
            points[3] = new Point((int)x1, (int)y2);
            _solidBrush = new SolidBrush(Color.LimeGreen);
            _graphics.FillPolygon(_solidBrush, points);
        }

        //Implement drawing a triangle
        public void DrawTriangle(double x1, double y1, double x2, double y2)
        {
            Point[] points = new Point[3];
            points[0] = new Point((int)(x1 + (x2 - x1) / 2), (int)y1);
            points[1] = new Point((int)x2, (int)y2);
            points[2] = new Point((int)x1, (int)y2);
            _solidBrush = new SolidBrush(Color.DodgerBlue);
            _graphics.FillPolygon(_solidBrush, points);
        }

        //Implement drawing a circle
        public void DrawCircle(double x1, double y1, double x2, double y2)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle((int)x1, (int)y1, (int)(x2 - x1), (int)(y2 - y1));
            _solidBrush = new SolidBrush(Color.Red);
            _graphics.FillEllipse(_solidBrush, rectangle);
        }

        //Implement drawing a line
        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            _graphics.DrawLine(Pens.DodgerBlue, (int)x1, (int)y1, (int)x2, (int)y2);
        }

        //Implement clearing all graphics
        public void ClearAll()
        {
            //Automatically clears the graphics when OnPaint invoked
        }

        private Graphics _graphics;
        private SolidBrush _solidBrush;
    }
}
