using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawingModel;

namespace DrawingForm
{
    public partial class DrawingForm : Form
    {
        Model _model;
        PresentationModel _presentationModel;

        public DrawingForm()
        {
            InitializeComponent();

            _model = new Model();
            _presentationModel = new PresentationModel(_model);
            _model._modelChanged += HandleModelChanged;
        }

        //Undo the last action
        private void ClickUndoButton(object sender, EventArgs e)
        {
            _model.Undo();
        }

        //Redo the last action
        private void ClickRedoButton(object sender, EventArgs e)
        {
            _model.Redo();
        }

        //Change the drawing mode into rectangle mode
        private void ClickRectangleButton(object sender, EventArgs e)
        {
            _model.DrawingMode = DrawingMode.Rectangle;
        }

        //Change the drawing mode into triangle mode
        private void ClickTriangleButton(object sender, EventArgs e)
        {
            _model.DrawingMode = DrawingMode.Triangle;
        }

        //Change the drawing mode into circle mode
        private void ClickCircleButton(object sender, EventArgs e)
        {
            _model.DrawingMode = DrawingMode.Circle;
        }

        //Change the drawing mode into line mode
        private void ClickLineButton(object sender, EventArgs e)
        {
            _model.DrawingMode = DrawingMode.Line;
        }

        //Save the image in bmp format
        private void ClickSaveButton(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            saveFileDialog.Filter = "點陣圖/Bitmap Image|*.bmp";
            saveFileDialog.Title = "另存新檔";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(_pictureBox.Width, _pictureBox.Height);
                _pictureBox.DrawToBitmap(image, _pictureBox.ClientRectangle);
                image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }

        //Open the google drive uploading UI to upload the file
        private void ClickUploadButton(object sender, EventArgs e)
        {

        }

        //Invoked when pressing the cursor on the canvas
        private void HandlePictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            _model.PressPointer(e.X, e.Y);
        }

        //Invoked when moving the cursor on the canvas
        private void HandlePictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            _model.MovePointer(e.X, e.Y);
        }

        //Invoked when releasing the cursor from the canvas
        private void HandlePictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            _model.ReleasePointer(e.X, e.Y);
        }

        //Invoked when the control is redrawn
        private void HandlePictureBoxPaint(object sender, PaintEventArgs e)
        {
            _presentationModel.Draw(e.Graphics);
        }

        //Invoked when the model is changed
        private void HandleModelChanged()
        {
            Invalidate(true);
            _undoButton.Enabled = _model.IsUndoEnabled;
            _redoButton.Enabled = _model.IsRedoEnabled;
        }
    }
}
