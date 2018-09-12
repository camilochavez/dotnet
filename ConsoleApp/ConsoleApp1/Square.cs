namespace Shapes
{
    public class Square
    {
        private int height;
        private int width;

        public Square(int height)
        {
            this.height = height;            
        }

        public int Width { get => width; set => width = value; }

        public int getArea()
        {
            return height * Width;
        }
    }
}
