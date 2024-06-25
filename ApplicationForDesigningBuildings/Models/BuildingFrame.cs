using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForDesigningBuildings
{
    internal class BuildingFrame
    {
        private string _name;
        private int _width;
        private int _height;
        private int _horizontalPosition;
        private int _verticalPosition;
        private int _strokeWidth;
        private Color _strokeColor;
        private Color _interiorElementColor;

        public string Name { get { return _name; } set { _name = value; } }
        public int Width { get { return _width; } set { _width = value; } }
        public int Height { get { return _height; } set { _height = value; } }
        public int HorizontalPosition { get { return _horizontalPosition; } set { _horizontalPosition = value; } }
        public int VerticalPosition { get { return _verticalPosition; } set { _verticalPosition = value; } }
        public int StrokeWidth { get { return _strokeWidth; } set { _strokeWidth = value; } }
        public Color StrokeColor { get { return _strokeColor; } set { _strokeColor = value; } }
        public Color InteriorElementColor { get { return _interiorElementColor; } set { _interiorElementColor = value; } }

        public BuildingFrame()
        {

        }
        public BuildingFrame(string name ,int _width, int _height, int _horizontalPosition, int _verticalPosition, int _strokeWidth, Color _elementColor, Color _interiorElementColor)
        {
            Name = _name;
            Width = _width;
            Height = _height;
            HorizontalPosition = _horizontalPosition;
            VerticalPosition = _verticalPosition;
            StrokeWidth = _strokeWidth;
            StrokeColor = _elementColor;
            InteriorElementColor = _interiorElementColor;
        }


    }
}
