using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op1;
            int op2;
            string operation;
            Console.WriteLine("Ingrese el primer valor");//Console.WriteLine() is a function which writes in a console
            op1 = int.Parse(Console.ReadLine());//Console.ReadLine() is a function which reads a string from user
            Console.WriteLine("Ingrese el segundo valor");
            op2 = int.Parse(Console.ReadLine());//int.Parse() is a function which converts strings to int
            Console.WriteLine("Ingrese la operación");
            operation = Console.ReadLine();

            int result = 0;
            switch (operation)
            {
                case "+":
                    result = op1 + op2;
                    break;
                case "-":
                    result = op1 - op2;
                    break;
                case "*":
                    result = op1 * op2;
                    break;
                case "/":
                    result = op1 / op2;
                    break;
                default:
                    Console.WriteLine("No se encontró la operación");
                    break;
            }
            Console.WriteLine(result.ToString());
            Console.Read();
        }
    }
}
