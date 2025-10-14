using System;
using System.Threading;
using ToDoList.Models;

namespace ToDoList
{
    class program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("¿Quieres agregar una tarea?");
            //Tarea tarea1 = new Tarea();
            //tarea1.Escribirinfo();
            //Console.WriteLine($"La tarea es: {tarea1.Info}, la fecha de inicio es: {tarea1.FechaInico}, la fecha limite es: {tarea1.FechaLimite}");




            //Aqui creo una lista de tareas para poder almacenar todas las tareas que el usuario vaya creando. Es importante mencionar que la lista es de tipo Tarea, ya que es la clase que he creado para definir las propiedades y metodos de una tarea
            List<Tarea> ListaTareas = new List<Tarea>();


            //Aqui defino una variable para almacenar la respuesta del usuario, en caso de que quiera crar una tarea o no
            string Respuesta;
            Console.WriteLine("¿Quieres agregar una tarea? (si/no)");
            Respuesta = Console.ReadLine().ToLower();

            //aqui estoy creando un ciclo do while para que el usuario pueda agregar todas las tareas que quiera, hasta que decida no agregar mas
            do
            {
                Tarea tarea = new Tarea();
                tarea.Escribirinfo();
                //Aqui es donde agrego la tarea nueva a la lista de tareas
                ListaTareas.Add(tarea);
                Console.WriteLine("¿Quieres agregar otra tarea? (si/no)");

                //Aqui vuelvo a pedir la respuesta del usuario para saber si quiere agregar otra tarea o no
                Respuesta = Console.ReadLine().ToLower();
            } while (Respuesta == "si");

            //Finalmente aqui imprimo todas las tareas que el usuario ha creado. Esto lo hago usando un foreach para recorrer la lista de tareas y mostrar la información de cada una.
            Console.WriteLine("\nEstas son tus tareas:");

            foreach (Tarea t in ListaTareas) 
            {

                //Es importante mencionar que estoy usando el metodo ToShortDateString() para mostrar la fecha en un formato mas amigable y que el simbolo de $ me permite hacer interpolación de cadenas para incluir las variables dentro de la cadena de texto, esto al meterlo dentro de {}
                Console.WriteLine($"- {t.Info} | Inicio: {t.FechaInico.ToShortDateString()} | Límite: {t.FechaLimite.ToShortDateString()}");
            }
        }
    }
}
