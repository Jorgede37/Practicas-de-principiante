using System;
using Practica.Model;
namespace Practica
{
    internal class Program

        //Aqui estoy creadno el objeto bebida con ayuda de la clase Bebida y ded su construtor. Cuando declaro el objeto, utilizo los atributos que tiene la clase para asignarle valores mediante el constructor. Ademas al final mando a llamar el metodo Beber para mosrarlo en consola.
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("Coca cola", 1000);
            bebida.Beber(200);
            Console.WriteLine(bebida.Cantidad);
        }
    }
}
