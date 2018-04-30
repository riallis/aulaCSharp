using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            triangulo x, y;
            x = new triangulo();
            y = new triangulo();

            x.a = double.Parse(Console.ReadLine());
            x.b = double.Parse(Console.ReadLine());
            x.c = double.Parse(Console.ReadLine());

            y.a = double.Parse(Console.ReadLine());
            y.b = double.Parse(Console.ReadLine());
            y.c = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(x.Area());
            Console.WriteLine(y.Area());
            
        }
    }
}
