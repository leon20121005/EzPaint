using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    abstract class Shape
    {
        //Call graphics interface to draw a shape
        public abstract void Draw(IGraphics graphic);

        //Determine if the shape is selected
        public abstract bool IsSelected(double pointX, double pointY);

        //Access to the property X1
        public double X1
        {
            get;
            set;
        }

        //Access to the property Y1
        public double Y1
        {
            get;
            set;
        }

        //Access to the property X2
        public double X2
        {
            get;
            set;
        }

        //Access to the property Y2
        public double Y2
        {
            get;
            set;
        }
    }
}
