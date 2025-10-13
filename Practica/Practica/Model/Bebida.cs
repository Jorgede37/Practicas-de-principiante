using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Aqui declaro el namespace, lo que es basicamente como una carpeta donde puedo guaradar mis clases

namespace Practica.Model
{
    //Aqui estoy declarando la clase Bebida, donde asigno los atributos y metodos que tendrá
    public class Bebida
    {
        //Asigno los atributos que tendra la clase, que en este caso seran Nombre y Cantidad
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        //Aqui declaro el constructor de la clase. Basicamente es el que se encarga de dar un valor inicial a los atributos. Aqui no le estoy dando un valor perce, si no que se lo asigno al crear el objeto.

        public Bebida(String Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }
        //Este es el unico metodo que tiene la clase, el cual es el de beber. Este metodo es basicamente una operacion que le resta la cantidad bebida a la cantidad total declarada en el objeto, esto con ayuda del constructor.
        public void Beber(int CuantoBebio) 
        {
            this.Cantidad -= CuantoBebio;
        }
    }
}
