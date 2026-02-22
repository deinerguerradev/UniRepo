using System;
using System.Collections.Generic;
using System.Threading;

namespace ProcesoIngreso
{
    class AdminFunctions
    {
        private static void DisplayAllUsers()
        {
            foreach(var userNames in Program.UserBasicInfo)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; 
                Console.WriteLine($"User Name: {userNames.Key}"); 
                foreach (var userDetails in userNames.Value)
                {
                    Console.ForegroundColor = ConsoleColor.Gray; 
                    Console.WriteLine($"-{userDetails}"); 
                    Console.ResetColor(); 
                }
            }
        }
        private static void DisplaySpecificUser ()
        {
            Console.Write("Ingesa el nombre del estudiante: ");
            string userName = Console.ReadLine(); 

            if (userName.Contains(userName))
            {
                
                foreach (var details in Program.UserBasicInfo[userName])
                {
                    Console.WriteLine(details); 
                }
     
            }
        }
        public static void SingUp()
        {
            Console.Write("Ingresa tu nombre: ");
            string admiName = Console.ReadLine(); 

            Console.Write("Ingresa tu Contraseña: ");
            string AdmiPassword = Console.ReadLine(); 

            if ((admiName == Program.AdmiName && AdmiPassword == Program.AdmiPassword) || (admiName == Program.AdmiName2 && AdmiPassword == Program.AdmiPassword2))
            {
                Console.WriteLine("Puede realizar las sigueintes acciones");
                Console.WriteLine("1. Ver todos los estudiantes y detalles");
                Console.WriteLine("2. ver a un estudiante y sus detalles");
                Console.WriteLine("3. Terminar Programa");

                Upload.Motion(); 
                
                while (true)
                {
                    Console.Write("Ingresa una de las opciones anteriores: "); 
                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1": 
                            DisplayAllUsers(); 
                            break; 
                        case "2": 
                            DisplaySpecificUser(); 
                            break; 
                        case "3":
                            Console.WriteLine("Estas saliendo de AdmiFunctions...");
                            Upload.Motion(); 
                            return; 

                    }
                }

            }  
        }
    }
}