using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Triangulo: IPieza
    {
        decimal ladoA { get; set; }
        decimal ladoB { get; set; }
        decimal hipotenusa { get; set; }
        public Triangulo(decimal LadoA, decimal LadoB)
        {
            ladoA = LadoA;
            ladoB = LadoB;
            hipotenusa = calculohipotenusa(ladoA, ladoB);
        }

        public decimal calculohipotenusa(decimal ladoA, decimal ladoB)
        {
            return (decimal)Math.Sqrt((double)(ladoA * ladoA) + (double)(ladoB * ladoB));
        }
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
