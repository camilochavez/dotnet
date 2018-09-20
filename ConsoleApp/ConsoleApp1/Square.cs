using System;

namespace Shapes
{
    public class Square
    {
        private int height;
        private int width;
        public event EventHandler ChangeWidth;

        public Square(int height)
        {
            this.height = height;
        }

        public int Width
        {
            get => width;
            set
            {
                ChangeWidth(this, new WidthEventArgs(value, width));
                width = value;
            }
        }

        public int GetArea()
        {
            return height * Width;
        }
    }

    public class WidthEventArgs : EventArgs
    {
        public int NewWidth { get; set; }
        public int OldWidth { get; set; }
        public WidthEventArgs(int newWidth, int oldWidth)
        {
            NewWidth = newWidth;
            OldWidth = oldWidth;
        }
    }
}
