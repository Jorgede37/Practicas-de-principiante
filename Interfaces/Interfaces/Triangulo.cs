using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    //Aqio estoy implementado la interfaz IPieza en la clase Triangulo. Por lo tanto debo implementar los metodos area y perimetro.
    internal class Triangulo: IPieza
    {
        decimal ladoA { get; set; }
        decimal ladoB { get; set; }
        decimal hipotenusa { get; set; }
        public Triangulo(decimal LadoA, decimal LadoB)

        //El valor de la hipotenusa se calcula con el teorema de pitagoras. Ese valor lo consigo con el metodo calculohipotenusa y lo asigno a la propiedad hipotenusa.
        {
            ladoA = LadoA;
            ladoB = LadoB;
            hipotenusa = calculohipotenusa(ladoA, ladoB);
        }
        //Aqui es donde digo que se calcula la hipotenusa
        public decimal calculohipotenusa(decimal ladoA, decimal ladoB)
        {
            return (decimal)Math.Sqrt((double)(ladoA * ladoA) + (double)(ladoB * ladoB));
        }

        //Aqui implemetno los metodos que instancia la interfaz IPieza. Es importante mencionar que si no los declaro en la clase Triangulo, el codigo no compila.
        public decimal area()
        {
            return (ladoA * ladoB / 2);
        }

        public decimal perimetro()
        {
            return (ladoA + ladoB + hipotenusa);
        }

    }
}
