using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Cuadrado: IPieza
    {
        public decimal lado { get; set; }
        public Cuadrado(decimal Lado) 
        {
            lado = Lado;
        }

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
