using System; 
using System.Threading; 
using System.Collections.Generic; 

namespace ProcesoIngreso 
{
    public static class Program 
    {
        public static string userName = ""; 
        public static string userIcfes = "";
        public static string userCarrer = ""; 
        public static string userFaculty = "";
        public static string userPassword = "";   
        public static List<string> UserName = new List<string>(); 
        public static List<string> UserPasswsword = new List<string>();
        public static Dictionary<string, List<string>> UserBasicInfo = new Dictionary<string, List<string>>(); 
        public static List <int> UserId = new List<int>(); 
        public static List<bool> IsRegister = new List<bool>(); 
        public static List<bool> IsAdmited = new List<bool>(); 
        public static List<bool> IsAprobbed = new List<bool>(); 
        public static List<bool> IsEnrolled = new List<bool>();
        public static Dictionary <string, List<string>> Carreras = new Dictionary<string, List<string>>
                    {

                        {"Ingenieria", new List<string> { "==========", "Ingenieria civil", "Ingenieria de Sistemas", "Ingenieria Ambiental", "Ingenieria Industrial", "Ingenieria Mecanica", "Arquitectura", "=========="}},
                        {"Ciencias", new List<string> { "==========", "Biología", "Quimica", "Arqueología", "=========="}}, 
                        {"Humanidades", new List<string> {"==========", "trabajo Social", "Psicología","Comunicación Social", "==========" }},

                    }; 

        

        public static void Main (string [] args) 
        {
            //Desplegamos una bienvenida para el usuario
            Console.WriteLine("==========================================="); 
            Console.WriteLine("\nBienvenido a Uniguajira");
            Console.WriteLine("Esta es la plataforma para controlar tu proceso\n"); 
            Console.WriteLine("===========================================");

            Thread.Sleep(3000); 

            //establecemos el bucle principal de nuestro programa 
            
            while (true)
            {
                
                //Establecemos los procesos que puede realizar el aspirante 
                List<string> accionesDelUsuario = new List<string>{"1. Inscribirse", "2. Revisar El estado De Aspirante", "3. Presentar la prueba", "4. Resvisar los resultados de la prueba", "5. Subir Docuementos Para Matricula", "6. Estado de Matricula", "7. Salir"};
                Console.WriteLine("Puedes hacer las siguientes Acciónes");

                //imprimimos las opciones para el usuario
                foreach(var acciones in accionesDelUsuario)
                {
                    Console.WriteLine(acciones); 
                }

                //Le pedimos al usario que ingrese una opcion
                Console.WriteLine("Ingresa una de las opciones anteriores, (1, 2, 3, 4, 5 o 7)"); 
                var opcion = Console.ReadLine(); 

                //Procesamos la entrada del usuario
                if(int.TryParse(opcion, out int accion))
                {
                    if (accion == 7)
                    {
                        Console.WriteLine("Esta saliendo de la aplicación");
                        Thread.Sleep(3000);  
                        return; 
                    }
                    Thread.Sleep(2000); 
                    InputManagment.ProcesarAccion(accion); 
                }
                else
                {
                    //le decimos al usuario que no a ingresado una entrada valida
                    Console.WriteLine("Ingresa una entrada valida (1, 2, 3, 4, 5, 6 o 7)"); 
                }
                  
            }

        }
    }
}
