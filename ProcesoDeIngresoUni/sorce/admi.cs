using System; 
using System.Collections.Generic; 

namespace Process
{
    class Admi
    {
        public static void Functions ()
        {
            // le pedimos al administrador que ingrese sus datos 
            Console.Write("Ingresa tu nombre: "); 
            string name = Console.ReadLine(); 

            Console.Write("Ingresa tu contraseña: ");
            string password = Console.ReadLine(); 

            // procesamos la entrada 
            if (name == Program.AdmiName && password == Program.AdmiPassword)
            {
                Console.WriteLine("Pudes Imprimir todos los usuarios y su información");
                Console.WriteLine("Ingresa una opcion (S/N)");
                string opcion = Console.ReadLine().ToLower(); 

                if (opcion == "s")
                {
                    DisplayAllUser(); 
                }  
                else
                {
                    Console.WriteLine("Saliendo...");
                    return;  
                }
            } 
        }
        public static void DisplayAllUser()
        {
            foreach (var user in Program.UserInfo.Keys)
            {
                Console.WriteLine($"-{user}"); 
                var details = Program.UserInfo[user];
                Console.WriteLine($"Constraseña: {details.Password}");
                Console.WriteLine($"Carrera: {details.Career}");
                Console.WriteLine($"Tarjeta de Identidad: {details.Id}");
                Console.WriteLine($"Icfes: {details.Icfes}");    
            }
        }
    }
}