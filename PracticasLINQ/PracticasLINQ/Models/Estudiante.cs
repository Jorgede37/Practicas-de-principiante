using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Esta clase representa un estudiante con propiedades como id, edad, nombre y carrera. Basicamente es cómo si estuviera creando los campos de una tabla de una base de datos, pero en este caso es una clase de C#.
namespace PracticasLINQ.Models
{
    public class Estudiante
    {
        public int id { get; set; }
        public int edad { get; set; }
        public string nombre { get; set; }
        public string carrera { get; set; }

        //Debo recordar que al constructor le pasas los parametros que vas a usar para inicializar los atributos de la clase.
        public Estudiante(int id, int edad, string nombre, string carrera) //En esta parte fue donde le asigne los valores a los atributos de la clase Estudiante.
        {
            this.id = id;
            this.edad = edad;
            this.nombre = nombre;
            this.carrera = carrera;

        }

    }
    
}
