using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class Model
    {
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();

        //Allocate the memory for the shape and assign the beginning point when pressing the cursor
        public void PressPointer(double pointX, double pointY)
        {
            if (pointX > 0 && pointY > 0 && _drawingMode != DrawingMode.Null)
            {
                CreateShape();
                _beginPointX = pointX;
                _beginPointY = pointY;
                _hintShape.X1 = pointX;
                _hintShape.Y1 = pointY;
                _isPointerPressed = true;
            }
            else if (_shapes.Count != 0)
            {
                StartMovingShape(pointX, pointY);
            }
        }

        //Assign or update the ending point when dragging the cursor
        public void MovePointer(double pointX, double pointY)
        {
            if (_isPointerPressed && _drawingMode != DrawingMode.Null)
            {
                _hintShape.X2 = pointX;
                _hintShape.Y2 = pointY;
                NotifyModelChanged();
            }
            if (_isPointerPressed && _drawingMode == DrawingMode.Null)
            {
                _hintShape.X1 = _previousX1 + pointX - _beginPointX;
                _hintShape.Y1 = _previousY1 + pointY - _beginPointY;
                _hintShape.X2 = _previousX2 + pointX - _beginPointX;
                _hintShape.Y2 = _previousY2 + pointY - _beginPointY;
                NotifyModelChanged();
            }
        }

        //Update the final ending point and execute the drawing command when releasing the cursor
        public void ReleasePointer(double pointX, double pointY)
        {           
            if (_isPointerPressed && _drawingMode != DrawingMode.Null)
            {
                Shape shape = _hintShape;
                _isPointerPressed = false;
                _commandManager.Execute(new DrawCommand(this, _hintShape));
                NotifyModelChanged();
            }
            if (_isPointerPressed && _drawingMode == DrawingMode.Null)
            {
                Shape shape = _hintShape;
                _hintShape.X1 = _previousX1;
                _hintShape.Y1 = _previousY1;
                _hintShape.X2 = _previousX2;
                _hintShape.Y2 = _previousY2;
                _isPointerPressed = false;
                _commandManager.Execute(new MoveCommand(this, shape, pointX - _beginPointX, pointY - _beginPointY));
                NotifyModelChanged();
            }
            _drawingMode = DrawingMode.Null;
        }

        //Add the shape into the shape list
        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        //Delete the certain shape from the shape list
        public void RemoveShape(Shape shape)
        {
            _shapes.Remove(shape);
        }

        //Delete the last shape from the shape list
        public void RemoveLastShape()
        {
            _shapes.RemoveAt(_shapes.Count - 1);
        }

        //Print all shapes in the shape list and the hint shape
        public void Draw(IGraphics graphics)
        {
            graphics.ClearAll();
            foreach (Shape shape in _shapes)
            {
                shape.Draw(graphics);
            }
            if (_isPointerPressed)
            {
                _hintShape.Draw(graphics);
            }
        }

        //Execute the undo
        public void Undo()
        {
            _commandManager.Undo();
            NotifyModelChanged();
        }

        //Execute the redo
        public void Redo()
        {
            _commandManager.Redo();
            NotifyModelChanged();
        }

        //Assign the drawing mode
        public DrawingMode DrawingMode
        {
            get
            {
                return _drawingMode;
            }
            set
            {
                _drawingMode = value;
            }
        }

        //Return the enabled state of the undo button
        public bool IsUndoEnabled
        {
            get
            {
                return _commandManager.IsUndoEnabled;
            }
        }

        //Return the enabled state of the redo button
        public bool IsRedoEnabled
        {
            get
            {
                return _commandManager.IsRedoEnabled;
            }
        }

        //Allocate the memory for the shape
        private void CreateShape()
        {
            switch (_drawingMode)
            {
                case DrawingMode.Rectangle:
                    _hintShape = new Rectangle();
                    break;
                case DrawingMode.Triangle:
                    _hintShape = new Triangle();
                    break;
                case DrawingMode.Circle:
                    _hintShape = new Circle();
                    break;
                case DrawingMode.Line:
                    _hintShape = new Line();
                    break;
            }
        }

        //Determine the selected shape and save the starting point
        private void StartMovingShape(double pointX, double pointY)
        {
            _shapes.Reverse();
            foreach (Shape shape in _shapes)
            {
                if (shape.IsSelected(pointX, pointY))
                {
                    _hintShape = shape;
                    _beginPointX = pointX;
                    _beginPointY = pointY;
                    _previousX1 = _hintShape.X1;
                    _previousY1 = _hintShape.Y1;
                    _previousX2 = _hintShape.X2;
                    _previousY2 = _hintShape.Y2;
                    _isPointerPressed = true;
                    NotifyModelChanged();
                    break;
                }
            }
            _shapes.Reverse();
        }

        //Notify that model has changed
        private void NotifyModelChanged()
        {
            _modelChanged?.Invoke();
        }

        private Shape _hintShape;
        private List<Shape> _shapes = new List<Shape>();
        private CommandManager _commandManager = new CommandManager();

        private double _beginPointX, _beginPointY;
        private double _previousX1, _previousY1, _previousX2, _previousY2;
        private bool _isPointerPressed = false;
        private DrawingMode _drawingMode = DrawingMode.Null;
    }
}
