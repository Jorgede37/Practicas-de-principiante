using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//En esta clase estoy creando una clase llamada Tarea, en donde estpy definiendo las propiedades y atributos de una tarea
namespace ToDoList.Models
{

    //Aqui defino la clase y lo primero que hago es definir los atributos
    public class Tarea
    {
        public string Info { get; set; }
        public DateTime FechaInico { get; set; }
        public DateTime FechaLimite { get; set; }
    //Aqui estoy definiendo el constructor de la clase
        public Tarea()
        {
            this.Info = "";
            this.FechaInico = DateTime.Now;
            this.FechaLimite = DateTime.Now;
        }

        //Aqui defino el metodo de la clase. En el cual pido al usuario que ingrese la información de la tarea

        public void Escribirinfo()
        {
            Console.WriteLine("Por favor escribe la Tarea que quieres agregar");
            Info = Console.ReadLine();
            Console.WriteLine("Por favor escribe la fecha de inicio de la tarea en formato: yyyy-MM-dd");

            //Aqui hago un parse para convertir el string que ingresa el usuario a un DateTime
            FechaInico = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Por favor escribe la fecha limite de la tarea formato: yyyy-MM-dd");
            FechaLimite = DateTime.Parse(Console.ReadLine());
        }



    }

}
