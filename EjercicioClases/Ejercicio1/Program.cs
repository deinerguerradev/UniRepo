using System; 

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        { 
            while(true)
            {
                Console.Write("Ingrese un número: ");
                int numero = Convert.ToInt16(Console.ReadLine()); 

                if (numero % 2 == 0)
                {
                    Console.WriteLine("El número es Par"); 
                }
                else
                {
                    Console.WriteLine("el número no es par");
                }
                Console.WriteLine("Salir (s/n)");
                string respuesta = Console.ReadLine().ToLower(); 

                if (respuesta == "s")
                {
                    Console.WriteLine("saliendo de la aplicación"); 
                    break; 
                }
                
            }
        }
    }
}
