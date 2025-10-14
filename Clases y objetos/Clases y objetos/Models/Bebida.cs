using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;\

//Aqui declaro el namespace para guardar las clases como si fueran una carpeta y despues reutilizarlas como si fueran una libreria

namespace Clases_y_objetos.Models

    //Aqui estoy creando la clase Bebida a la que le asigno atributos, metodos y su constructor
{
    public class Bebida
    {
        //Estos son los atributos de la clase
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        //Este es el constructor de la clase
        public Bebida(string nombre, int cantidad) 
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
        }
        //Este es el metodo de la clase, en los emtodos es doonde construyes la logica de la clase
        public void Beber(int CuantoBebio) 
        {
            this.Cantidad -= CuantoBebio;
        }
    }
}
