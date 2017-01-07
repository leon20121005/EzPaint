using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using DrawingModel;

namespace DrawingApp
{
    class PresentationModel
    {
        Model _model;
        IGraphics _graphics;

        public PresentationModel(Model model, Canvas canvas)
        {
            _model = model;
            _graphics = new WindowsStoreGraphicsAdaptor(canvas);
        }

        //Draw all shapes
        public void Draw()
        {
            _model.Draw(_graphics);
        }
    }
}
