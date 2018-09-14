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
            square.Width = width;
            int area = square.getArea();
            Console.WriteLine("el area del cuadrado es: " + area);
            Console.Read();         
        }
    }
}
