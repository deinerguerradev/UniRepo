using System; 
using System.Collections.Generic;

namespace Process
{
    class Test
    {
        public static void Beggin()
        {
            //le pedimos al usuario que ingrese sus credenciales
            Console.Write("Ingresa tu nombre: ");
            string name = Console.ReadLine(); 

            Console.Write("Ingresa tu contraseña: ");
            string password = Console.ReadLine(); 

            // verificamos que este en el sistema
            if (Enroll.ValidUserCredencial(name, password))
            {
                var user = Program.UserInfo[name]; 
                Faculty(user.Career); 
            }
        }
        
        public static bool Faculty (string career)
        {
            
            if (career == "civil")
            {
                Console.WriteLine("1. En la ingenieria se integran procesos matematicas y cientificos orientados a la resulucion de problemas del mundo real? (V/F)"); 
                char a = Console.ReadKey().KeyChar; 

                Console.WriteLine("2. En una construccion las estructuras que sostienen una casa son los bloques (V/F)");  
                char b = Console.ReadKey().KeyChar; 

                if (AnswerReview(a, b))
                {
                    Console.WriteLine("Te admitieron!"); 
                    return true;     
                }
                else
                {
                    return false; 
                }
                
            }
            else if (career == "sistemas")
            {
                Console.WriteLine("1. En la ingenieria se integran procesos matematicas y cientificos orientados a la resulucion de problemas del mundo real? (V/F)"); 
                char a = Console.ReadKey().KeyChar; 

                Console.WriteLine("2. En programación python y C# son lenguajes interpretados (V/F)");  
                char b = Console.ReadKey().KeyChar; 

                if (AnswerReview(a, b))
                {
                    Console.WriteLine("Te admitieron!"); 
                    return true;     
                }
                else
                {
                    return false; 
                }
            }
            else if (career == "industrial")
            {
                Console.WriteLine("1. En la ingenieria se integran procesos matematicas y cientificos orientados a la resulucion de problemas del mundo real? (V/F)"); 
                char a = Console.ReadKey().KeyChar; 

                Console.WriteLine("2. Un proceso optimizado no permite ahorrar tiempo (V/F)");  
                char b = Console.ReadKey().KeyChar; 

                if (AnswerReview(a, b))
                {
                    Console.WriteLine("Te admitieron!"); 
                    return true;     
                }
                else
                {
                    return false; 
                }
            }
            else
            {
                return false;
            }
        }
        public static bool AnswerReview(char a, char b)
        {
            if (a == 'V' && b == 'F'){return true;}
            else {return false;}
        }
    }
}