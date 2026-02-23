using System; 
using System.Collections.Generic; 

namespace Process
{
    class Enroll
    {
    
        public static void RegisterInfo ()
        {
            //le peidmos al usuario que ingrese algunas credenciales para registrarlo en el sistema
            Console.WriteLine("==================");
            Console.WriteLine("INSCRIPCIÓN");  
            Console.WriteLine("=================="); 

            Program.LoandingAnimation(); 

            Console.Write("Ingresa tu nombre 1re nombre y apellido: "); 
            string userName = Console.ReadLine(); 

            Console.Write("Ingresa tu tarjeta de identidad: "); 
            string userId = Console.ReadLine(); 

            Console.Write("Ingrsa una contraseña: ");
            string userPassword = Console.ReadLine(); 

            Console.Write("Resultado Icfes: "); 
            int userIcfes = Convert.ToInt32(Console.ReadLine()); 

            if (userIcfes != 0 && userId != "" && userPassword != "" && userName != "")
            {
                Console.WriteLine("Ingenieria: ");
                int i = 1; 
                foreach (var career in Program.Faculty["Ingenieria"])
                {
                    Console.WriteLine( i+". " + career);
                    i++;  
                }

                //Le decimos al usuario que tiene que seleccionar una de esas carreras
                Console.WriteLine("Ingresa una de las carreras anteriores"); 
                string userCareer = Console.ReadLine().ToLower(); 

                if (userCareer == "sistemas" || userCareer == "civil" || userCareer == "industrial")
                {
                    RegisterUser(userName, userIcfes, userPassword, userCareer, userId);
                    Console.WriteLine($"Tu usuario es: {userName} y tu contraseña: {userPassword}"); 
                }  
            } 
            

        }
        public static void RegisterUser (string name, int icfes, string Password, string career, string id)
        {
            Program.UserInfo[name] = new Users
            {
                Password = Password,
                Career = career, 
                Id = id,
                Icfes = icfes,
            };
        }
        public static void Result()
        {
            //Le pedmios al usuario que ingrese sus credeciales basicas
            Console.Write("Ingresa tu usuario: "); 
            string userName = Console.ReadLine(); 

            Console.Write("Ingresa tu contraseña: ");
            string userPassword = Console.ReadLine(); 

            //verificamos si esta en el "sistema" osea en el diccionario
            if (ValidUserCredencial(userName, userPassword))
            {
                Console.WriteLine("Inicio de sección exitoso"); 
                Console.WriteLine("Se mostraran los resultados en breve..."); 
                Program.LoandingAnimation(); 
                var user = Program.UserInfo[userName]; 
                AdmiteResult.User(user.Icfes, user.Career); 
            }
        }
        
        public static bool ValidUserCredencial(string name, string password)
        {
            if (Program.UserInfo.ContainsKey(name))
            {
                return Program.UserInfo[name].Password == password; 
            }
            return false; 
        }
    }
}