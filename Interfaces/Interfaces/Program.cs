using System;
namespace Interfaces
{
    internal class Program
    {
        //Aqui podria crear objetos de las clases Cuadrado y Triangulo y llamar a los metodos area y perimetro. Pero en lugar de eso, voy a crear objetos de tipo IPieza que es la interfaz que implementan ambas clases. De esta manera puedo usar polimorfismo y tratar a ambos objetos de la misma manera.
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
