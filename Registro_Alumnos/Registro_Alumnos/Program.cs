using Registro_Alumnos;
using System;
using System.Collections.Generic;

namespace Registro_Alumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true; // controla el ciclo del menú
            List<Alumno> alumnos = new List<Alumno>();

            while (continuar)
            {
                try
                {
                    Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
                    Console.WriteLine("1. Agregar Alumno");
                    Console.WriteLine("2. Mostrar alumnos");
                    Console.WriteLine("3. Buscar alumno por nombre");
                    Console.WriteLine("4. Salir");
                    Console.Write("Selecciona una opción: ");

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Alumno nuevoAlumno = Alumno.agregar_alumno();
                            alumnos.Add(nuevoAlumno);
                            Console.WriteLine("\nAlumno agregado correctamente.");
                            break;

                        case "2":
                            if (alumnos.Count == 0)
                            {
                                Console.WriteLine("\nNo hay alumnos registrados.");
                            }
                            else
                            {
                                Console.WriteLine("\n=== LISTA DE ALUMNOS ===");
                                foreach (Alumno alumno in alumnos)
                                {
                                    Console.WriteLine($"Nombre: {alumno.Nombre}, Edad: {alumno.Edad}, Promedio: {alumno.Promedio}");
                                }
                            }
                            break;

                        case "3":
                            Console.Write("\nIngresa el nombre del alumno que deseas buscar: ");
                            string nombreBuscado = Console.ReadLine();
                            Alumno encontrado = alumnos.Find(a => a.Nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase));

                            if (encontrado != null)
                            {
                                Console.WriteLine($"Alumno encontrado: {encontrado.Nombre}, Edad: {encontrado.Edad}, Promedio: {encontrado.Promedio}");
                            }
                            else
                            {
                                Console.WriteLine("No se encontró un alumno con ese nombre.");
                            }
                            break;

                        case "4":
                            continuar = false; // termina el ciclo
                            Console.WriteLine("Saliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Intenta de nuevo.");
                            break;
                    }

                    // Solo preguntar si no eligió salir
                    if (continuar)
                    {
                        Console.Write("\n¿Deseas realizar otra acción? (s/n): ");
                        string respuesta = Console.ReadLine().ToLower();
                        continuar = (respuesta == "s" || respuesta == "si");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nOcurrió un error: {ex.Message}");
                    Console.WriteLine("Por favor, intenta de nuevo.\n");
                }
            }

            Console.WriteLine("\nPrograma finalizado. Presiona cualquier tecla para cerrar...");
            Console.ReadKey();
        }
    }
}

