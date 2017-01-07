using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media;
using DrawingModel;

namespace DrawingApp
{
    class WindowsStoreGraphicsAdaptor : IGraphics
    {
        public WindowsStoreGraphicsAdaptor(Canvas canvas)
        {
            _canvas = canvas;
        }

        //Implement drawing a rectangle
        public void DrawRectangle(double x1, double y1, double x2, double y2)
        {
            Polygon polygon = new Polygon();
            Canvas.SetLeft(polygon, 0);
            Canvas.SetTop(polygon, 0);
            polygon.Points.Add(new Windows.Foundation.Point(x1, y1));
            polygon.Points.Add(new Windows.Foundation.Point(x2, y1));
            polygon.Points.Add(new Windows.Foundation.Point(x2, y2));
            polygon.Points.Add(new Windows.Foundation.Point(x1, y2));
            polygon.Fill = new SolidColorBrush(Colors.LimeGreen);
            _canvas.Children.Add(polygon);
        }

        //Implement drawing a triangle
        public void DrawTriangle(double x1, double y1, double x2, double y2)
        {
            Polygon polygon = new Polygon();
            Canvas.SetLeft(polygon, 0);
            Canvas.SetTop(polygon, 0);
            polygon.Points.Add(new Windows.Foundation.Point((x2 - x1) / 2 + x1, y1));
            polygon.Points.Add(new Windows.Foundation.Point(x2, y2));
            polygon.Points.Add(new Windows.Foundation.Point(x1, y2));
            polygon.Fill = new SolidColorBrush(Colors.DodgerBlue);
            _canvas.Children.Add(polygon);
        }

        //Implement drawing a circle
        public void DrawCircle(double x1, double y1, double x2, double y2)
        {
            if (x2 < x1)
            {
                SwapDouble(ref x1, ref x2);
            }
            if (y2 < y1)
            {
                SwapDouble(ref y1, ref y2);
            }
            Ellipse ellipse = new Ellipse();
            Canvas.SetLeft(ellipse, x1);
            Canvas.SetTop(ellipse, y1);
            ellipse.Width = x2 - x1;
            ellipse.Height = y2 - y1;
            ellipse.Fill = new SolidColorBrush(Colors.Red);
            _canvas.Children.Add(ellipse);
        }

        //Implement drawing a line
        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            Windows.UI.Xaml.Shapes.Line line = new Windows.UI.Xaml.Shapes.Line();
            line.X1 = x1;
            line.Y1 = y1;
            line.X2 = x2;
            line.Y2 = y2;
            line.Stroke = new SolidColorBrush(Colors.DodgerBlue);
            _canvas.Children.Add(line);
        }

        //Implement clearing all graphics
        public void ClearAll()
        {
            _canvas.Children.Clear();
        }

        //Swap two double numbers
        private void SwapDouble(ref double first, ref double second)
        {
            double temporary;
            temporary = first;
            first = second;
            second = temporary;
        }

        private Canvas _canvas;
    }
}
