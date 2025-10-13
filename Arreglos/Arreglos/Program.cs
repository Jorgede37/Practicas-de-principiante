using System.Runtime.Serialization.Formatters;

namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)

            //Aqui estoy declarando un array de numeros enteros. Basicamente primero se ceclara el tipo de variable y despues se usa como si fuera un objeto
        {
            int[] numeros = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

            //Aqui estoy declarando un for basico. Basicamente primero se declara una variable incremental, despues de pone la condicion para esa variable y despues se pone el incremento

            for (int i = 0; i < numeros.Length; i++) 
            {
                Console.WriteLine(numeros[i]);
                
            }

            //Aqui mande a llamar a la clase Metodo?Lista para que se ejeute en el metodo Main principal de este proyecto
            Metodo_Lista metodoLista = new Metodo_Lista();
            metodoLista.Main(args);
        }

            

    }
    //Aqui estoy creando una clase distinta llamada Metodo_Lista. Basicamente estoy haciendo lo mismo que con la clase Program, pero usando listas en vez de arrays. La diferencia entre una lista y un array es que las Listas tienen tamaños dimamicos y en los arrays debes declararlos

    public class Metodo_Lista 
    {
        public void Main(string[] args)
        {
            Console.WriteLine("***************************************************");
            List<int> numeros = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8};

            foreach (var  numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
        
        
        
    }
}
