using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Alumnos
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public float Edad { get; set; }

        public float Promedio { get; set; }

        public Alumno(string nombre, float edad, float promedio)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Promedio = promedio;
        }

        public static Alumno agregar_alumno()
        {
            Console.WriteLine("Escribe el nombre del alumno que quieres agregar");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Escribe la edad del alumno que quieres agregar");
            float Edad = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el promedio del alumno que quieres agregar");
            float Promedio = float.Parse(Console.ReadLine());

            return new Alumno(Nombre, Edad, Promedio);
        }
    }
}
