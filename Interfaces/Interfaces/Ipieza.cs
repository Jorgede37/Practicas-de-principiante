using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aqui estoy definiendo la interfaz donde declaro los metodos que deben estar si o si en las clases que implementen esta interfaz. Los metodos son muy genericos, no tienen cuerpo, solo la firma.
namespace Interfaces
{
    //Cuando declaro una interfaz por convencion su nombre empieza con I. En este caso tiene el nombre Ipieza.
    public interface IPieza
    {

        //Los metodos que declaro en la interfaz deben ser implementados en las clases que implementen esta interfaz.
        decimal area();
        decimal perimetro();    
    }
}
