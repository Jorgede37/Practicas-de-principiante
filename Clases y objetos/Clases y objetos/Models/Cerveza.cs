using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//En esta parte estoy practicando uno de los 4 pilares de POO que es la herencia, en la que una clase hija hereda los atributos y metodos de una clase padre

namespace Clases_y_objetos.Models
{

    //Aqui estoy creando la clase hija llamada Cerveza, la cual hereda los atrubutos y metodos de la clase padre llamada Bebida
    public class Cerveza : Bebida
    {
        //Este es el constructor de la clase hija, en el que le doy valores predeterminados a los atributos heredados de la clase padre
        //Es importante que el constructor de la clase hija llame al constructor de la clase padre con la palabra base
        public Cerveza() : base ("Cerveza", 500)
        {
        }
    }
}
