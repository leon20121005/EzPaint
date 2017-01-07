using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using DrawingModel;

//空白頁項目範本收錄在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DrawingApp
{
    /// <summary>
    /// 可以在本身使用或巡覽至框架內的空白頁面。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Model _model;
        PresentationModel _presentationModel;

        public MainPage()
        {
            this.InitializeComponent();

            _model = new Model();
            _presentationModel = new PresentationModel(_model, _canvas);
            _model._modelChanged += HandleModelChanged;
        }

        //Undo the last action
        private void ClickUndoButton(object sender, RoutedEventArgs e)
        {
            _model.Undo();
        }

        //Redo the last action
        private void ClickRedoButton(object sender, RoutedEventArgs e)
        {
            _model.Redo();
        }

        //Change the drawing mode into rectangle mode
        private void ClickRectangleButton(object sender, RoutedEventArgs e)
        {
            _model.DrawingMode = DrawingMode.Rectangle;
        }

        //Change the drawing mode into triangle mode
        private void ClickTriangleButton(object sender, RoutedEventArgs e)
        {
            _model.DrawingMode = DrawingMode.Triangle;
        }

        //Change the drawing mode into circle mode
        private void ClickCircleButton(object sender, RoutedEventArgs e)
        {
            _model.DrawingMode = DrawingMode.Circle;
        }

        //Change the drawing mode into line mode
        private void ClickLineButton(object sender, RoutedEventArgs e)
        {
            _model.DrawingMode = DrawingMode.Line;
        }

        //Save the image in bmp format
        private async void ClickSaveButton(object sender, RoutedEventArgs e)
        {
            const int PIXEL = 96;
            RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap();
            await renderTargetBitmap.RenderAsync(_canvas);
            var picker = new Windows.Storage.Pickers.FileSavePicker();
            picker.FileTypeChoices.Add("點陣圖/Bitmap Image", new string[] { ".bmp" });
            Windows.Storage.StorageFile file = await picker.PickSaveFileAsync();
            if (file != null)
            {
                var pixels = await renderTargetBitmap.GetPixelsAsync();
                using (Windows.Storage.Streams.IRandomAccessStream stream = await file.OpenAsync(Windows.Storage.FileAccessMode.ReadWrite))
                {
                    var encoder = await
                    Windows.Graphics.Imaging.BitmapEncoder.CreateAsync(Windows.Graphics.Imaging.BitmapEncoder.BmpEncoderId, stream);
                    byte[] bytes = pixels.ToArray();
                    encoder.SetPixelData(Windows.Graphics.Imaging.BitmapPixelFormat.Bgra8,
                                         Windows.Graphics.Imaging.BitmapAlphaMode.Ignore,
                                         (uint)_canvas.ActualWidth,
                                         (uint)_canvas.ActualHeight, PIXEL, PIXEL, bytes);
                    await encoder.FlushAsync();
                }
            }
        }

        //Open the google drive uploading UI to upload the file
        private void ClickUploadButton(object sender, RoutedEventArgs e)
        {

        }

        //Invoked when pressing the cursor on the canvas
        private void HandleCanvasPointerPressed(object sender, PointerRoutedEventArgs e)
        {
            _model.PressPointer(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
        }

        //Invoked when moving the cursor on the canvas
        private void HandleCanvasPointerMoved(object sender, PointerRoutedEventArgs e)
        {
            _model.MovePointer(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
        }

        //Invoked when releasing the cursor from the canvas
        private void HandleCanvasPointerReleased(object sender, PointerRoutedEventArgs e)
        {
            _model.ReleasePointer(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
        }

        //Invoked when the model is changed
        private void HandleModelChanged()
        {
            _presentationModel.Draw();
            _undoButton.IsEnabled = _model.IsUndoEnabled;
            _redoButton.IsEnabled = _model.IsRedoEnabled;
        }
    }
}
