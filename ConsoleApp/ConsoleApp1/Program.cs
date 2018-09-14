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
            width = int.Parse(Console.ReadLine());
            Square square = new Square(height);
            SquareStruct squareStruct = new SquareStruct(height, width);
            square.Width = width;
            SetWidthToSquare(square);
            int area = square.getArea();
            Console.WriteLine("el area del cuadrado es: (Class)" + area);
            SetWidthToSquare(squareStruct);
            area = squareStruct.getArea();
            Console.WriteLine("el area del cuadrado es: (Struct)" + area);
            Console.Read();
        }

        static void SetWidthToSquare(SquareStruct square)
        {
            square.Width = 50;
        }
        static void SetWidthToSquare(Square square)
        {
            square.Width = 50;
        }
    }
}
