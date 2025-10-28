using System;
using System.Collections.Generic;
using System.Linq;
using PracticasLINQ.Models;

// Esta clase contiene el método Main que ejecuta consultas LINQ sobre listas de números y objetos Estudiante.
//Ademas tambien estuve probando consultas LINQ tanto con la sintaxis de consulta como con la sintaxis de método.
namespace PracticasLINQ
{
    internal class Program
    {
        static void Main(string[] args)

        //Aqui declare un array de numeros y use LINQ para seleccionar los numeros pares e imprimirlos en la consola. La sintaxis es muy similar a SQL.
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerospares = from n in numeros
                              where n % 2 == 0
                              select n; 
            foreach (var n in numerospares)
            {
                Console.WriteLine(n);
            }
            //En esta parte del codigo, cree una lista de objetos Estudiante y use LINQ para filtrar los estudiantes mayores de 20 años e imprimir sus detalles en la consola.

            //Debo mencionar que meti el query dentro de una lista para poder recorrerla con un foreach y mostrar los resultados en la consola.
            List<Estudiante> lista = new()
            {
                new Estudiante(1,20,"Juan","Informatica"),
                new Estudiante(2,22,"Maria","Matematicas"),
                new Estudiante(3,21,"Pedro","Fisica"),
                new Estudiante(4,23,"Ana","Informatica"),
                new Estudiante(5,20,"Luis","Matematicas"),
            };

            var mayores = lista.Where(static e => e.edad > 20);

            //En esta parte utilizo la variable creada dentro del foreach para mostrar los resultados en la consola. Es importante recordar que al usar el foreach, la variable que se crea dentro de el representa cada elemento de la coleccion que estamos recorriendo.
            //Adeemas utilice el metodo where anteriormente para establecer la condicion de filtrado. Esto denr¿tro de la lista de estudiantes.
            foreach (var estudiante in mayores)
            {
                Console.WriteLine($"\nID: {estudiante.id}, Nombre: {estudiante.nombre}, Edad: {estudiante.edad}, Carrera: {estudiante.carrera}");
            }


        }
    }
}
