using System; 
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata;
using System.Threading; 

namespace Process
{
    class Users
    {
        public string Password { get; set; }
        public string Id {get; set; }
        public int Icfes {get; set; }
        public string Career {get; set;}


    }
    class Program
    {
        public static string AdmiName = "Adanud"; 

        public static string AdmiPassword = "123456_"; 
        public static Dictionary <string, Users> UserInfo = new Dictionary<string, Users>(); 

        public static Dictionary <string, List<string>> Faculty = new Dictionary<string, List<string>>
        {
            { "Ingenieria", new List<string> { "civil", "sistemas", "industrial" } },

        };  



        public static void Main (string [] agrs)
        {
            DisplayOptions(); 
        }

        public static void DisplayOptions ()
        {
            bool salir = false; 
            while(!salir){
                Console.WriteLine("======================");
                Console.WriteLine("UNIVERSIDAD DE LA GUAJIRA");  
                Console.WriteLine("======================"); 

                LoandingAnimation(); 

                Console.WriteLine("Bienvenido al proceso para ingresar a la universidad de la guajira");

                Console.WriteLine("\nPuedes realizar las sigueintes acciones: ");  
                string[] actions = {"1. Inscribirse", "2. Revisar estado de Inscripción", "3. Realizar prueba", "4. cargar Documentos", "5. Funciónes de aministrador", "6. salir"};

                for (int i = 0; i<actions.Length; i++)
                {
                    Console.WriteLine(actions[i]); 
                }

                Console.WriteLine("Ingresa una de las acciones anteriores"); 
                string action = Console.ReadLine(); 

                ProcessAction(action, salir);

                LoandingAnimation(); 
                  
            }
        }

        public static void ProcessAction(string action, bool salir)
        {

            switch (action)
            {
                case "1":
                    Enroll.RegisterInfo();  
                    break;
                case "2":
                    Enroll.Result();  
                    break;
                case "3":
                    Test.Beggin();
                    break;
                case "4":
                    Document.Uploand(); 
                    break;
                case "5":
                    Admi.Functions();  
                    break;
                case "6":
                    salir = false;   
                    break;
                default: 
                    Console.WriteLine("Ingresa un valor valido 1-8");
                    break;  
                 
            }
        }

        public static void LoandingAnimation()
        {
            for (int i = 0; i<5; i++)
            {
                Console.Write("="); 
                Thread.Sleep(1000); 
            }
            Console.WriteLine(); 
        }
    }
}