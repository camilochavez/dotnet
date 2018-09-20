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
            square.ChangeWidth += new EventHandler(Square_Change);
            square.Width = width;
            int area = square.GetArea();
            Console.WriteLine("el area del cuadrado es: " + area);
            Console.Read();
        }

        static void Square_Change(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("El ancho del cuadrado cambió: nuevo valor " + ((WidthEventArgs)eventArgs).NewWidth + " Valor anterior " + ((WidthEventArgs)eventArgs).OldWidth);
        }
    }
}
