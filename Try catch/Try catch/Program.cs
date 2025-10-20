using System.Security.Cryptography.X509Certificates;

namespace Try_catch

//Este programa es muy simple. Solicita al usuario que ingrese la cantidad de productos y el precio por unidad. Después, calcula el total a pagar multiplicando la cantidad por el precio. Si el usuario ingresa un valor no numérico, el programa captura la excepción FormatException y muestra un mensaje de error indicando que el formato de entrada no es válido.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double cantidad, precio, Total;
            //Aqui se usa el metodo try-catch para manejar posibles errores de formato en la entrada del usuario. Lo que hace es intentar ejecutar el bloque de codigo dentro del try, y si ocurre una excepcion de tipo FormatException, se ejecuta el bloque catch correspondiente.
            try
            {
                Console.WriteLine("Ingrese la cantidad de productos: ");
                cantidad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el precio del producto");
                precio = Convert.ToDouble(Console.ReadLine());
                Total = cantidad * precio;
                Console.WriteLine("El total a pagar es: " + Total);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Formato de entrada no válido. Por favor, ingrese un número válido.");
            }

        }
    }
}
