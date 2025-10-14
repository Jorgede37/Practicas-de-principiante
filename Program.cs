using System;

//En esta parte estoy importando la clase bebida con ayuda del namespace que cree en la carpeta bebida
using Clases_y_objetos.Models;
namespace Clases_y_objetos
{



    //Aqui estoy creado la clase principal del programa, en la que creare un objeto de la calse bebida y usare el metodo beber que hice en la clase bebida
    internal class Program
    {
        static void Main(string[] args)
        {

            //Con ayuda del constructor de la clase bebida estoy creando un objeto llamado bebida1, y le doy valor a sus atributos dentro del parentesis
            Bebida bebida1 = new Bebida("Coca cola", 100);
            bebida1.Beber(50);  // En esta linea estoy usando el metodo beber que cree en la clase bebida, y le paso como parametro 50

            //Aqui imprimo en consola la cantidad que queda de la bebida despues de haber usado el metodo beber
            Console.WriteLine($"Bebiste 50 de {bebida1.Nombre}, ahora quedan {bebida1.Cantidad}");
        }
    }
}
