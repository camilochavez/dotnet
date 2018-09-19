using Shapes;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 0;
            int width = 0;
            Console.WriteLine("Ingrese la altura y el ancho del cuadrado");
            height = int.Parse(Console.ReadLine());
            
            bool isnumber=int.TryParse(Console.ReadLine(), out width);
            if (!isnumber)
            {
                Console.WriteLine("El ancho ingresado no es un número");
                Console.Read();
                return; }
            Square square = new Square(height);
            SquareStruct squareStruct = new SquareStruct(height, width);
            square.Width = width;
            SetWidthToSquare(square);
            int area = square.getArea();
            Console.WriteLine("el area del cuadrado es: (Class)" + area);
            SetWidthToSquare(out squareStruct);
            area = squareStruct.getArea();
            Console.WriteLine("el area del cuadrado es: (Struct)" + area);
            Console.Read();
        }

        static void SetWidthToSquare(out SquareStruct square)
        {
            square = new SquareStruct();
            square.Width = 50;
        }
        static void SetWidthToSquare(Square square)
        {
            Random random = new Random(20);            
            square.Width = random.Next();
        }
    }
}
