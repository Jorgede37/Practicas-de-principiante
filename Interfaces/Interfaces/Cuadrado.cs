using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{//Aqui estoy implementado la interfaz IPieza en la clase Cuadrado. Por lo tanto debo implementar los metodos area y perimetro.
    internal class Cuadrado: IPieza
    {
        //Aqui declaro el atributo lado que es el unico que necesito para calcular el area y el perimetro del cuadrado.
        public decimal lado { get; set; }
        //El constructor de la clase Cuadrado recibe el valor del lado y lo asigna a la propiedad lado.
        public Cuadrado(decimal Lado) 
        {
            lado = Lado;
        }
        //Aqui estoy recibiendo los metodos instanciados en la interfaz IPieza. Es importante mencionar que si no los declaro en la clase Cuadrado, el codigo no compila.
        public decimal area()
        {
            return lado * lado;
        }

        public decimal perimetro()
        {
            return lado * 4;
        }
    }
}
