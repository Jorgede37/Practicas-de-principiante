using System;
namespace calculadora_basica
{
    class HelloWorld
    {
        static void Main()
        {
            float num1;
            float num2;


            Console.WriteLine("Escribe + para realizar una suma\n" + "Escribe - para realizar una resta\n" + "Escribe x para realizar una multiplicación\n" + "Escribe / para realizar una división");
            string operador = Console.ReadLine().ToLower();
            if (operador != "+" && operador != "-" && operador != "x" && operador != "/")
            {
                Console.WriteLine("Elije un operador valido.");
                return;
            }
            Console.WriteLine("Ahora escribe el valor del primer numero");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ahora escribe el valor del segundo numero");
            num2 = float.Parse(Console.ReadLine());

            if (operador == "+")
            {
                Console.WriteLine("La suma es de: " + (num1 + num2));
            }

            else if (operador == "-")
            {
                Console.WriteLine("La resta es de: " + (num1 - num2));
            }

            else if (operador == "x")
            {
                Console.WriteLine("La multiplicación es: " + (num1 * num2));
            }

            else if (operador == "/")
            {
                Console.WriteLine("El resultado de la división es: " + (num1 / num2));
            }

        }
    }

}