using System; 
using System.Collections.Generic; 

namespace Process
{
    class Document
    {
        public static void Uploand ()
        {
            Console.WriteLine("Ingresa una fotocopia de tu docuemtno de identidad, presiona la letra T");
            ConsoleKeyInfo teclaT = Console.ReadKey(); 

            Console.WriteLine("Ingresa una foto fondo azul 3x4, presiona la tecla F");
            ConsoleKeyInfo teclaF = Console.ReadKey(); 

            Console.WriteLine("Ingresa un docuemnto relacionado con identidad culturañ, presiona la C");
            ConsoleKeyInfo teclaC = Console.ReadKey(); 

            if (teclaT.KeyChar == 't' && teclaF.KeyChar == 'f' && teclaC.KeyChar == 'c')
            {
                Console.WriteLine("Se subieron todos los docuementos"); 
                Result(); 
            } 
        
        }
        public static void Result ()
        {
            Console.WriteLine("Ya estas Matriculado");
        }
    }
}