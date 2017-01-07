using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DrawingModel;

namespace DrawingForm
{
    class PresentationModel
    {
        Model _model;

        public PresentationModel(Model model)
        {
            _model = model;
        }

        //Draw all shapes
        public void Draw(Graphics graphics)
        {
            _model.Draw(new WindowsFormsGraphicsAdaptor(graphics));
        }
    }
}
