using System;
namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPieza cuadrado = new Cuadrado(10);
            IPieza triangulo = new Triangulo(10,10);
            Console.WriteLine($"Area del cuadrado: {cuadrado.area()}");
            Console.WriteLine($"\nPerimetro del cuadrado: {cuadrado.perimetro()}");
            Console.WriteLine($"\nArea del triangulo: {triangulo.area()}");
            Console.WriteLine($"\nPerimetro del triangulo: {triangulo.perimetro()}");
        }
    }
}
