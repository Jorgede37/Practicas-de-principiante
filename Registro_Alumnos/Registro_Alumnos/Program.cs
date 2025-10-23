using Registro_Alumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Alumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar;
            //Falta agregar el try catch para que no truene si el usuario ingresa algo incorrecto

            List<Alumno> alumnos = new List<Alumno>();

            Console.WriteLine("Por favor selecciona el numero correspondiente de la opción que deseas elegir\n");
            Console.WriteLine("1. Agregar Alumno");
            Console.WriteLine("2. Mostrar alumnos");
            Console.WriteLine("3. Buscar alumno por nombre");
            Console.WriteLine("4. Salir");

            string opcion = Console.ReadLine();

            switch (opcion) 
            {
                case "1":
                    Alumno nuevoAlumno = Alumno.agregar_alumno();
                    alumnos.Add(nuevoAlumno);
                    break;

                case "2":
                    foreach (Alumno alumno in alumnos) 
                    {
                        Console.WriteLine($"Nombre: {alumno.Nombre}, Edad: {alumno.Edad}, Promedio: {alumno.Promedio}");
                        //Falta que se repita el menu despues de cada accion
                    }
                    break;


            }

        }
    }
}
